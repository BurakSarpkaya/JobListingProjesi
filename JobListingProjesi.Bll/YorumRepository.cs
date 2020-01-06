using JobListingProjesi.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobListingProjesi.Bll
{
    public class YorumRepository:BaseRepository<Yorum>
    {
        public List<Yorum> KullaniciYorumlariniGetir(int kullaniciId)
        {
            return context.Yorum.Where(x => x.KullaniciId == kullaniciId).ToList();
        }
        public List<Yorum> BlogYorumlariniGetir(int blogId)
        {
            return context.Yorum.Where(x => x.BlogId == blogId).ToList();
        }
    }
}
