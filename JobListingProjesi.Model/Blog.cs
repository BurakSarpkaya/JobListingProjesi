using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobListingProjesi.Model
{
    public class Blog:Base
    {
        
        [Required]
        public String Baslik { get; set; }
        public String ResimUrl { get; set; }
        [Required]
        public String Icerik { get; set; }
        [Required]
        [DefaultValue(0)]
        public int KategoriId { get; set; }
        public int KullaniciId { get; set; }
        public int OkunmaSayisi { get; set; }
        
        [ForeignKey("KategoriId")]
        public virtual Kategori Kategorisi { get; set; }
        [ForeignKey("KullaniciId")]
        public virtual Kullanici Kullanicisi { get; set; }
        
    }
}
