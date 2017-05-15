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
        private readonly RoleManager<BecketLeeRole> _roleManager;

        public BecketLeeSeedData(
            BecketLeeContext context, 
            UserManager<BecketLeeUser> userManager,
            RoleManager<BecketLeeRole> roleManager )
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

            var webBioUser = await _userManager.FindByNameAsync( "BioEditor" );
            if (webBioUser == null)
            {
                var bioEditor = new BecketLeeUser()
                {
                    UserName = "BioEditor",
                    Email = "bioEditor@becket-lee.com",
                    CreatedDate = DateTime.UtcNow
                };

                var userCheck = await _userManager.CreateAsync( bioEditor, "P@ssw0rd!" );
                if( userCheck.Succeeded )
                {
                    var roles = new[] { "BioEditor" };
                    await _userManager.AddToRolesAsync( bioEditor, roles );
                }
                else
                    throw new Exception( "Unable to create default bio user." );
            }

            var webEventUser = await _userManager.FindByNameAsync( "EventEditor" );
            if (webEventUser == null)
            {
                var eventEditor = new BecketLeeUser()
                {
                    UserName = "EventEditor",
                    Email = "eventEditor@becket-lee.com",
                    CreatedDate = DateTime.UtcNow
                };

                var userCheck = await _userManager.CreateAsync( eventEditor, "P@ssw0rd!" );
                if( userCheck.Succeeded )
                {
                    var roles = new[] { "EventEditor" };
                    await _userManager.AddToRolesAsync( eventEditor, roles );
                }
                else
                    throw new Exception( "Unable to create default event user." );
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
                var role = new BecketLeeRole();
                role.Name = "Administrator";
                role.Description = "The magic key to all things.";
                await _roleManager.CreateAsync( role );
            }

            if (!await _roleManager.RoleExistsAsync( "BioEditor" ))
            {
                var role = new BecketLeeRole();
                role.Name = "BioEditor";
                role.Description = "Allows editing on partner controller.";
                await _roleManager.CreateAsync( role );
            }

            if (!await _roleManager.RoleExistsAsync( "EventEditor" ))
            {
                var role = new BecketLeeRole();
                role.Name = "EventEditor";
                role.Description = "Allows editing on event controller.";
                await _roleManager.CreateAsync( role );
            }

        }

    }
}