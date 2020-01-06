using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobListingProjesi.Model
{
    public class Cv:Base
    {
        [ForeignKey("Kullanicisi")]
        public int KullaniciId { get; set; }
        [Required]
        public String CvAdi { get; set; }
        [Required]
        public String CvUrl { get; set; }
        public bool IsActive { get; set; }
        public bool GorunumDurumu { get; set; }
        public virtual Kullanici Kullanicisi { get; set; }
    }
}
