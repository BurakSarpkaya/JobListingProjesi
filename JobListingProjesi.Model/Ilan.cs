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
    public class Ilan:Base
    {
        public Ilan()
        {
            this.Basvurulari = new HashSet<Basvuru>();
        }
        public int SehirId { get; set; }
        public int FirmaId { get; set; }
        public int KategoriId { get; set; }
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public DateTime BaslangicTarihi { get; set; }
        [Required]
        [DefaultValue("2050-01-10")]
        public DateTime BitisTarihi { get; set; }
        [Required]
        [StringLength(100)]
        public String Baslik { get; set; }
        public String FotoUrl { get; set; }
        [DefaultValue(0)]
        public int GormeSayisi { get; set; }
        [ForeignKey("SehirId")]
        public virtual Sehir Sehri { get; set; }
        [ForeignKey("FirmaId")]
        public virtual Firma Firmasi { get; set; }
        [ForeignKey("KategoriId")]
        public virtual Kategori Kategorisi { get; set; }
        public ICollection<Basvuru> Basvurulari { get; set; }
    }
}
