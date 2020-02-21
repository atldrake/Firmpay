using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;

namespace Firmpay.Persistence
{
    public static class DataSeedingInitializer
    {
        public static async Task UserAndRoleSeedAsync(UserManager<IdentityUser> userManager,
                                                 RoleManager<IdentityRole> roleManager)
        {
            string[] roles = { "Admin", "Manager", "Staff" };
            foreach (var role in roles)
            {
                var roleExist = await roleManager.RoleExistsAsync(role);
                if (!roleExist)
                {
                    IdentityResult result = await roleManager.CreateAsync(new IdentityRole(role));
                }
            }

            //Create Admin User
            if (userManager.FindByEmailAsync("drake@firmtechsolution.com").Result == null)
            {
                IdentityUser user = new IdentityUser
                {
                    UserName = "drake@firmtechsolution.com",
                    Email = "drake@firmtechsolution.com"
                };
                IdentityResult identityResult = userManager.CreateAsync(user, "Password1").Result;
                if (identityResult.Succeeded)
                {
                    userManager.AddToRoleAsync(user, "Admin").Wait();
                }
            }

            //Create Manager User
            if (userManager.FindByEmailAsync("manager@firmtechsolution.com").Result == null)
            {
                IdentityUser user = new IdentityUser
                {
                    UserName = "manager@firmtechsolution.com", 
                    Email = "manager@firmtechsolution.com"
                };
                IdentityResult identityResult = userManager.CreateAsync(user, "Password1").Result;
                if (identityResult.Succeeded)
                {
                    userManager.AddToRoleAsync(user, "Manager").Wait();
                }
            }

            //Create Staff User
            if (userManager.FindByEmailAsync("staff@firmtechsolution.com").Result == null)
            {
                IdentityUser user = new IdentityUser
                {
                    UserName = "staff@firmtechsolution.com",
                    Email = "staff@firmtechsolution.com"
                };
                IdentityResult identityResult = userManager.CreateAsync(user, "Password1").Result;
                if (identityResult.Succeeded)
                {
                    userManager.AddToRoleAsync(user, "Staff").Wait();
                }
            }

            //Create No Role User
            if (userManager.FindByEmailAsync("norole@firmtechsolution.com").Result == null)
            {
                IdentityUser user = new IdentityUser
                {
                    UserName = "norole@firmtechsolution.com",
                    Email = "norole@firmtechsolution.com"
                };
                IdentityResult identityResult = userManager.CreateAsync(user, "Password1").Result;
                //No Role assigned to Mr John Doe
            }
        }
    }
}
