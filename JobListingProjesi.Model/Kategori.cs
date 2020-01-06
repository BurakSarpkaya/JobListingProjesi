using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobListingProjesi.Model
{
    public class Kategori:Base
    {
        public String Ad { get; set; }
        [ForeignKey("UstKategorisi")]
        public int? UstKategoriId { get; set; }
        public virtual Kategori UstKategorisi { get; set; }
    }
}
