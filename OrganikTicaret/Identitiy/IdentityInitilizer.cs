using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace OrganikTicaret.Identitiy
{
    public class IdentityInitilizer:DropCreateDatabaseIfModelChanges<IdentityDataContext>
    {
        
            protected override void Seed(IdentityDataContext context)
            {
                // Rolleri
                if (!context.Roles.Any(i => i.Name == "admin"))
                {
                    var store = new RoleStore<AppRole>(context);
                    var manager = new RoleManager<AppRole>(store);
                    var role = new AppRole() { Name = "admin", Description = "admin rolü" };
                    manager.Create(role);
                }

                if (!context.Roles.Any(i => i.Name == "user"))
                {
                    var store = new RoleStore<AppRole>(context);
                    var manager = new RoleManager<AppRole>(store);
                    var role = new AppRole() { Name = "user", Description = "user rolü" };
                    ;
                    manager.Create(role);
                }

                if (!context.Users.Any(i => i.Name == "hacer"))
                {
                    var store = new UserStore<AppUser>(context);
                    var manager = new UserManager<AppUser>(store);
                    var user = new AppUser() { Name = "hacer", SurName =  "dogan", UserName = "hacerd", Email = "hacer@gmail.com" };

                    manager.Create(user, "1234567");
                    manager.AddToRole(user.Id, "admin");
                    manager.AddToRole(user.Id, "user");
                }
                if (!context.Users.Any(i => i.Name == "merve"))
                {
                    var store = new UserStore<AppUser>(context);
                    var manager = new UserManager<AppUser>(store);
                    var user = new AppUser() { Name = "merve", SurName = "dogan", UserName = "merved", Email = "merve@gmail.com" };

                    manager.Create(user, "1234567");
                    manager.AddToRole(user.Id, "admin");
                    manager.AddToRole(user.Id, "user");
                }



                base.Seed(context);
            }
        }
    }