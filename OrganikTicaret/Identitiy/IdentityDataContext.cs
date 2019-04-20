using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Web;
using Microsoft.AspNet.Identity.EntityFramework;
using OrganikTicaret.Models;
using Login = System.Web.UI.WebControls.Login;

namespace OrganikTicaret.Identitiy
{
    public class IdentityDataContext : IdentityDbContext<AppUser>
    {
        public IdentityDataContext():base("dataConnection")
        {
            
        }
       
    }
}