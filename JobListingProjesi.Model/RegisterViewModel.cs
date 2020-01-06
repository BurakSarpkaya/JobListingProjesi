using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobListingProjesi.Model
{
    public class RegisterViewModel
    {
        [Required]
        public String KullaniciAdi { get; set; }
        [Required]
        public String Ad { get; set; }
        [Required]
        public String Soyad { get; set; }
        [Required]
        public String Email { get; set; }
        public String Telefon { get; set; }
        [Required]
        public String Sifre { get; set; }
        [Required]
        [Compare("Sifre", ErrorMessage = "Şifreler uyuşmuyor")]
        public String SifreTekrar { get; set; }
    }
}
