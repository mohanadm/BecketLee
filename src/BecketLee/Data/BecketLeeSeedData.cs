using System;
using System.Threading.Tasks;
using BecketLee.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace BecketLee.Data
{
    public class BecketLeeSeedData
    {
        protected BecketLeeContext _context;
        private readonly UserManager<BecketLeeUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;

        public BecketLeeSeedData(
            BecketLeeContext context, 
            UserManager<BecketLeeUser> userManager,
            RoleManager<IdentityRole> roleManager )
        {
            _context = context;
            _userManager = userManager;
            _roleManager = roleManager;
        }

        public async Task EnsureSeedData()
        {
            await EnsureRoleData();
            await EnsureUserData();
            await BecketLeePartnerSeedData.EnsurePartnerData( _context );
            await BecketLeeEventTypeSeedData.EnsureEventTypeData( _context );
            await BecketLeeEventSeedData.EnsureEventData( _context );
        }

        private async Task EnsureUserData()
        {
            var webUser = await _userManager.FindByNameAsync( "Webmaster" );
            if( webUser == null )
            {
                var webMaster = new BecketLeeUser()
                {
                    UserName = "Webmaster",
                    Email = "kgabrys@becket-lee.com",
                    CreatedDate = DateTime.UtcNow
                };

                var userCheck = await _userManager.CreateAsync( webMaster, "P@ssw0rd!" );
                if (userCheck.Succeeded)
                    await AddToAllRoles( webMaster );
                else
                    throw new Exception("Unable to create default user.");
            }
            else
            {                
                await AddToAllRoles( webUser );
            }
        }

        private async Task AddToAllRoles( BecketLeeUser webMaster )
        {
            var roles = new[] { "Administrator", "BioEditor", "EventEditor" };
            await _userManager.AddToRolesAsync( webMaster, roles );
        }


        private async Task EnsureRoleData()
        {
            if( !await _roleManager.RoleExistsAsync( "Administrator" ) )
            {
                var role = new IdentityRole();
                role.Name = "Administrator";
                await _roleManager.CreateAsync( role );
            }

            if (!await _roleManager.RoleExistsAsync( "BioEditor" ))
            {
                var role = new IdentityRole();
                role.Name = "BioEditor";
                await _roleManager.CreateAsync( role );
            }

            if (!await _roleManager.RoleExistsAsync( "EventEditor" ))
            {
                var role = new IdentityRole();
                role.Name = "EventEditor";
                await _roleManager.CreateAsync( role );
            }

        }

    }
}