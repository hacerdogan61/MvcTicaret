using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.Owin.Security;
using OrganikTicaret.Identitiy;
using OrganikTicaret.Models;

namespace OrganikTicaret.Controllers
{
    public class AccountController : Controller
    {
        private UserManager<AppUser> UserManager;
        private RoleManager<AppRole> RoleManager;
        IdentityDataContext db=new IdentityDataContext();
        public AccountController()
        {
            var userStore = new UserStore<AppUser>(new IdentityDataContext());
            UserManager = new UserManager<AppUser>(userStore);

            var roleStore = new RoleStore<AppRole>(new IdentityDataContext());
            RoleManager = new RoleManager<AppRole>(roleStore);

        }

        public ActionResult User()
        {
            var userInfo = db.Users.Include(l => l.Logins);
            return View(userInfo.ToList());
        }

        // GET: Account
        public ActionResult Register()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Register(Register model ,string ReturnUrl)
        {
            if (ModelState.IsValid)
            {
                //Kayıt işlemleri

                var user = new AppUser();
                user.Name = model.Name;
                user.SurName = model.surName;
                user.Email = model.Email;
                user.UserName = model.userName;
               

                var result = UserManager.Create(user, model.Password);

                if (result.Succeeded)
                {
                    //kullanıcı oluştu ve kullanıcıyı bir role atayabilirsiniz.
                    if (RoleManager.RoleExists("user"))
                    {
                        UserManager.AddToRole(user.Id, "user");
                    }
                    if (!String.IsNullOrEmpty(ReturnUrl))
                    {
                        return Redirect(ReturnUrl);
                    }
                    return RedirectToAction("Login", "Account");
                }
                else
                {
                    ModelState.AddModelError("RegisterUserError", "Kullanıcı  oluşturma hatası.");
                }

            }
           

            return View(model);
        }



        // GET: Account
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(Login model)
        {
            if (ModelState.IsValid)
            {
                //Login işlemleri
               var user = UserManager.Find(model.userName, model.Password);

                if (user != null)
                {
                    // varolan kullanıcıyı sisteme dahil et.
                    // ApplicationCookie oluşturup sisteme bırak.

                    var authManager = HttpContext.GetOwinContext().Authentication;
                    var identityclaims = UserManager.CreateIdentity(user, "ApplicationCookie");
                    var authProperties = new AuthenticationProperties();
                    authProperties.IsPersistent = model.RememberMe;
                    authManager.SignIn(authProperties, identityclaims);

                  

                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    ModelState.AddModelError("LoginUserError", "Böyle bir kullanıcı yok.");
                }
            }

            return View(model);
        }

        public ActionResult Logout()
        {
            var authManager = HttpContext.GetOwinContext().Authentication;
            authManager.SignOut();

            return RedirectToAction("Index", "Home");
        }

    }
}