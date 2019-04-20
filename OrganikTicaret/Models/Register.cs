using OrganikTicaret.Identitiy;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace OrganikTicaret.Models
{
    public class Register
    {   [Required]
        [DisplayName("Adınız")]
        public string Name { get; set; }
        [Required]
        [DisplayName("Soyadınız")]
        public string surName { get; set; }
        [Required]
        [DisplayName("Kullanıcı Adınız")]
        public string userName { get; set; }
        [Required]
        [DisplayName("Emailiniz")]
        [EmailAddress(ErrorMessage = "Böyle Bir Email Adresi Bulunmamaktadır")]
        public string Email { get; set; }
        [Required]
        [DisplayName("Şifreniz")]
        public string Password { get; set; }
        [Required]
        [DisplayName("Şifre Tekrarı")]
        [Compare("Password",ErrorMessage = "Girilen şifre ile uyuşmamaktadır")]
        public string RePassword { get; set; }
        
    }
}