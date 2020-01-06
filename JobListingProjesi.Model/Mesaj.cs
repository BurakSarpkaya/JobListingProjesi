using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobListingProjesi.Model
{
    public class Mesaj:Base
    {
        
        public int IlanId { get; set; }
        public int KullaniciId { get; set; }
        [Required]
        public String Icerik { get; set; }
        [Required]
        public String Baslik { get; set; }
        
        [ForeignKey("IlanId")]
        public virtual Ilan Ilani { get; set; }
        
    }
}
