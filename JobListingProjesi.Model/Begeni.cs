using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobListingProjesi.Model
{
    public class Begeni:Base
    {
        public int KullaniciId { get; set; }
        public int BlogId { get; set; }
        
        [ForeignKey("BlogId")]
        public virtual Blog Blogu { get; set; }
    }
}
