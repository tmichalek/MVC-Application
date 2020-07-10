using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using Zgloszenie_WebApplication.Models;

namespace Zgloszenie_WebApplication.ViewModel
{
    public class FirstAdminInitilization:DropCreateDatabaseAlways<ApplicationDbContext>
    {
        protected override void Seed(ApplicationDbContext context)
        {

            // Initialize default identity roles
            //var store = new RoleStore<IdentityRole>(context);
            //var manager = new RoleManager<IdentityRole>(store);

            ///////////////////////////////////////////
            var roleManager = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(context));
            var UserManager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(context));
            // RoleTypes is a class containing constant string values for different roles
            List<IdentityRole> identityRoles = new List<IdentityRole>();
            identityRoles.Add(new IdentityRole() { Name = "Admin" });
           
            identityRoles.Add(new IdentityRole() { Name = "User" });

            foreach (IdentityRole role in identityRoles)
            {
                roleManager.Create(role);
            }

            // Initialize default user
            //var store = new UserStore<ApplicationUser>(context);
            //var manager = new UserManager<ApplicationUser>(store);
            //ApplicationUser admin = new ApplicationUser();
            //admin.Email = "admin@admin.com";
            //admin.UserName = "admin@admin.com";

            //manager.Create(admin, "1Admin!");
            //manager.AddToRole(admin.Id, RoleTypes.Admin);
            var user = new ApplicationUser();
            user.UserName = "admin@admin.pl";
            user.Email = "admin@admin.pl";
            user.EmailConfirmed = true;

            string userPWD = "master";

            var chkUser = UserManager.Create(user, userPWD);

            //Add default User to Role Admin    
            if (chkUser.Succeeded)
            {
                var result1 = UserManager.AddToRole(user.Id, "Administrator");

            }
            //context.Roles.Add()
            //context.Users.Add(user);
            base.Seed(context);
        }
    }
}