using JobListingProjesi.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobListingProjesi.Bll
{
    public class CvRepository:BaseRepository<Cv>
    {
        public List<Cv> KullaniciCvsiGetir(int kullaniciId)
        {
            return context.Cv.Where(x => x.KullaniciId == kullaniciId).ToList();
        }
    }
}
