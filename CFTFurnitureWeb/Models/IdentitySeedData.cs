using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace CFTFurnitureWeb.Models
    {
    public static class IdentitySeedData
        {
        private const string adminUser = "Admin";
        private const string adminPassword = "Secret123$";

        private const string generalUser = "General";
        private const string generalPassword = "Secret456$";

       /*public static async void EnsurePopulated(IApplicationBuilder app)
            {
            /*UserManager<IdentityUser> userManager = app.ApplicationServices
            .GetRequiredService<UserManager<IdentityUser>>();
            IdentityUser user = await userManager.FindByIdAsync(adminUser);
            IdentityUser gralUser = await userManager.FindByIdAsync(generalUser);
            if (user == null || gralUser == null)
                {
                user = new IdentityUser("Admin");
                await userManager.CreateAsync(user, adminPassword);

                gralUser = new IdentityUser("General");
                await userManager.CreateAsync(gralUser, generalPassword);
                }

            }*/
        }
    }
