using JobListingProjesi.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobListingProjesi.Bll
{
    public class MesajRepository:BaseRepository<Mesaj>
    {
        public List<Mesaj> IlaninMesajlariniGetir(int ilanId)
        {
            return context.Mesaj.Where(x => x.IlanId == ilanId).ToList();
        }
    }
}
