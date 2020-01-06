using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobListingProjesi.Model
{
    public class Firma:Base
    {
        public Firma()
        {
            this.Ilanlari = new HashSet<Ilan>();
        }
        [Required]
        public String Ad { get; set; }
        [Required]
        public String Aciklama { get; set; }
        [Required]
        public String UserName { get; set; }
        [Required]
        public String Sifre { get; set; }

        public virtual ICollection<Ilan> Ilanlari { get; set; }
    }
}
