using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobListingProjesi.Model
{
    public class Iletisim:Base
    {
        [Required]
        public String Mesaj { get; set; }
        [Required]
        public String Konu { get; set; }
        [Required]
        public String KullaniciAdi { get; set; }
        [Required]
        [DataType(DataType.EmailAddress)]
        public String KullaniciMail { get; set; }
    }
}
