using JobListingProjesi.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobListingProjesi.Bll
{
    public class BegeniRepository:BaseRepository<Begeni>
    {
        public List<Begeni> BegeniGetir(int begeniId)
        {
            return context.Begeni.Where(x => x.Id == begeniId).ToList();
        }
    }
}
