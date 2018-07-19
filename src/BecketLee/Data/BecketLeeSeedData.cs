using System;
using System.Linq;
using System.Threading.Tasks;
using BecketLee.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Logging;

namespace BecketLee.Data
{
    public class BecketLeeSeedData
    {
        private BecketLeeContext _context;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly RoleManager<ApplicationRole> _roleManager;
        //private ILogger _logger;

        public BecketLeeSeedData(
            BecketLeeContext context, 
            UserManager<ApplicationUser> userManager,
            RoleManager<ApplicationRole> roleManager
            )
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
                var webMaster = new ApplicationUser()
                {
                    UserName = "Webmaster",
                    Email = "kgabrys@becket-lee.com",
                    CreatedDate = DateTime.UtcNow
                };

                var userCheck = await _userManager.CreateAsync( webMaster, "P@ssw0rd!" );
                if( userCheck.Succeeded )
                {
                    var roles = new[] { "Administrator" };
                    await _userManager.AddToRolesAsync( webMaster, roles );
                }                
                else
                    throw new Exception("Unable to create default user.");
            }
            else
            {
                string existingRole = _userManager.GetRolesAsync( webUser ).Result.Single();
                
                if ("Administrator" != existingRole )
                {
                    //if( webUser.Roles.Count > 0 )
                    //{
                        var allroles = new[] {"Administrator", "BioEditor", "EventEditor"};
                        await _userManager.RemoveFromRolesAsync( webUser, allroles );
                    //}
                    var roles = new[] {"Administrator"};
                    await _userManager.AddToRolesAsync( webUser, roles );
                }
            }

            var webBioUser = await _userManager.FindByNameAsync( "BioEditor" );
            if (webBioUser == null)
            {
                var bioEditor = new ApplicationUser()
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
                var eventEditor = new ApplicationUser()
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


        private async Task EnsureRoleData()
        {
            if( !await _roleManager.RoleExistsAsync( "Administrator" ) )
            {
                var role = new ApplicationRole();
                role.Name = "Administrator";
                role.Description = "The magic key to all things.";
                await _roleManager.CreateAsync( role );
            }

            if (!await _roleManager.RoleExistsAsync( "BioEditor" ))
            {
                var role = new ApplicationRole();
                role.Name = "BioEditor";
                role.Description = "Allows editing on partner controller.";
                await _roleManager.CreateAsync( role );
            }

            if (!await _roleManager.RoleExistsAsync( "EventEditor" ))
            {
                var role = new ApplicationRole();
                role.Name = "EventEditor";
                role.Description = "Allows editing on event controller.";
                await _roleManager.CreateAsync( role );
            }

        }

    }
}