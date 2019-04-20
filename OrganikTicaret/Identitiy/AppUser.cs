using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.Identity.EntityFramework;

namespace OrganikTicaret.Identitiy
{
    public class AppUser:IdentityUser
    {
        public string Name { get; set; }
        public string SurName { get; set; }
        public AppRole role { get; set; }
       
    }
}