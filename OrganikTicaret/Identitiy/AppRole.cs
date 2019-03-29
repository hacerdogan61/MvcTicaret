using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.Identity.EntityFramework;

namespace OrganikTicaret.Identitiy
{
    public class AppRole:IdentityRole
    {
        public string Description { get; set; }
        public AppRole()
        {
            
        }
        public AppRole(string roleName,string description)
        {
            this.Description = description;
        }
    }
}