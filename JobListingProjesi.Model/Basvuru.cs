using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobListingProjesi.Model
{
    public class Basvuru:Base
    {
        public int KullaniciId { get; set; }
        public int IlanId { get; set; }
        public int CvId { get; set; }
        [ForeignKey("KullaniciId")]
        public virtual Kullanici Kullanicisi { get; set; }
        [ForeignKey("IlanId")]
        public virtual Ilan Ilani { get; set; }
        
    }
}
