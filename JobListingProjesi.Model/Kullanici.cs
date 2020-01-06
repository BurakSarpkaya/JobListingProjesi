using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobListingProjesi.Model
{
    public class Kullanici:Base
    {
        public Kullanici()
        {
            this.Basvurulari = new HashSet<Basvuru>();
            this.Cvleri = new HashSet<Cv>();
            this.Bloglari = new HashSet<Blog>();
            
        }

        [Required]
        public String Ad { get; set; }
        [Required]
        public String Soyad { get; set; }
        [Required]
        public String UserName { get; set; }
        [Required]
        [DataType(DataType.EmailAddress)]
        public String Mail { get; set; }
        [Required]
        public String Sifre { get; set; }
        public String Telefon { get; set; }
        [DefaultValue(false)]
        public bool IsOnline { get; set; }
        public virtual ICollection<Basvuru> Basvurulari { get; set; }
        public virtual ICollection<Cv> Cvleri { get; set; }
        public virtual ICollection<Blog> Bloglari { get; set; }
        

    }
}
