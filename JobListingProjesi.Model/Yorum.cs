using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobListingProjesi.Model
{
    public class Yorum:Base
    {
        public int KullaniciId { get; set; }
        public int BlogId { get; set; }
        [Required]
        public String Icerik { get; set; }
        [ForeignKey("KullaniciId")]
        public virtual Kullanici Kullanicisi { get; set; }
        
    }
}
