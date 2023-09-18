using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CoreDemo.Models
{
    public class UserSignUpViewModel
    {
        [Display(Name = "Ad Soyad")]
        [Required(ErrorMessage = "Ad Soyad daxil edin")]
        public string NameSurname { get; set; }
        
        
        [Display(Name = "Şifrə")]
        [Required(ErrorMessage = "Şifrə daxil edin")]
        public string Password { get; set; }

        
        [Display(Name = "Şifrə Təkrar")]
        [Compare("Password",ErrorMessage ="Şifrələr eyni deyil")]
        public string ConfirmPassword { get; set; }


        [Display(Name = "Mail Adresi")]
        [Required(ErrorMessage = "Mail daxil edin")]
        public string Mail { get; set; }


        [Display(Name = "İstifadəçi adı")]
        [Required(ErrorMessage = "İstifadəçi adınızı daxil edin")]
        public string UserName { get; set; }



    }
}
