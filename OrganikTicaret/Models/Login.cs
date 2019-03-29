using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace OrganikTicaret.Models
{
    public class Login
    {
         [Required]
        [DisplayName("Kullanıcı Adınız")]
        public string userName { get; set; }
        [Required]
        [DisplayName("Şifreniz")]
        public string Password { get; set; }
     
        [DisplayName("Beni Hatırla")]
        public bool RememberMe { get; set; }

    }
}