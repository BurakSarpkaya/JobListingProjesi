using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace JobListingProjesi.Model
{
    public class Base
    {
        public int Id { get; set; }
        public DateTime KayitTarihi { get; set; }
        public bool IsDelete { get; set; }
    }
}
