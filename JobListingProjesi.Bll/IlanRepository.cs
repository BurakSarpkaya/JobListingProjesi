using JobListingProjesi.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobListingProjesi.Bll
{
    public class IlanRepository:BaseRepository<Ilan>
    {
        public List<Ilan> SehrinIlanlariniGetir(int sehirId)
        {
            return context.Ilan.Where(x => x.SehirId == sehirId).ToList();
        }
        public List<Ilan> FirmaninIlanlariniGetir(int firmaId)
        {
            return context.Ilan.Where(x => x.FirmaId == firmaId).ToList();
        }
    }
}
