using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace asp.net_core_deneme2.Models
{
    public class Student
    {
        [Required(ErrorMessage ="İsminizi giriniz.")]
        public String Name { get; set; }
        
        [Required(ErrorMessage = "mail giriniz")]
        [EmailAddress(ErrorMessage ="mail formatınız yanlış")]
        public String Email { get; set; }
        [Required(ErrorMessage = "numaranızı giriniz.")]
        public String Phone{ get; set; }
        [Required(ErrorMessage = "Lütfen işaretleyin.")]
        public bool? WillAttend { get; set; } //bilgi girmezse otomatik false olur bu şekilde yaparsak uyarı verdirebiliriz


    }
}
