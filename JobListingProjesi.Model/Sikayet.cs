using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobListingProjesi.Model
{
    public class Sikayet:Base
    {
        public int KullaniciId { get; set; }
        public int IlanId { get; set; }

        [ForeignKey("IlanId")]
        public virtual Ilan Ilani { get; set; }
    }
}
