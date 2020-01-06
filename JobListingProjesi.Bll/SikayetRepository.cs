using JobListingProjesi.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobListingProjesi.Bll
{
    public class SikayetRepository:BaseRepository<Sikayet>
    {
        public List<Sikayet> IlaninSikayetleriniGetir(int ilanId)
        {
            return context.Sikayet.Where(x => x.IlanId == ilanId).ToList();
        }
    }
}
