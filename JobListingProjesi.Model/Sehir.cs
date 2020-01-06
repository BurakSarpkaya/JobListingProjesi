using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobListingProjesi.Model
{
    public class Sehir:Base
    {
        public Sehir()
        {
            this.Ilanlari = new HashSet<Ilan>();
        }
        public String Ad { get; set; }
        public String UlkeAdi { get; set; }

        public virtual ICollection<Ilan> Ilanlari { get; set; }
    }
}
