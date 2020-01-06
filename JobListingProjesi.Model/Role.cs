using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobListingProjesi.Model
{
    public class Role:Base
    {
        public Role()
        {
            this.Kullanicilari = new HashSet<Kullanici>();
        }
        [Required]
        public String Ad { get; set; }

        public virtual ICollection<Kullanici>Kullanicilari { get; set; }
    }
}
