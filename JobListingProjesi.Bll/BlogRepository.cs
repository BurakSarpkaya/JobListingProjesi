using JobListingProjesi.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobListingProjesi.Bll
{
    public class BlogRepository:BaseRepository<Blog>
    {
        public List<Blog> BlogunKategorileriniGetir(int kategoriId)
        {
            return context.Blog.Where(x => x.KategoriId == kategoriId).ToList();
        }
        public List<Blog> BlogunKullanicilariniGetir(int kullaniciId)
        {
            return context.Blog.Where(x => x.KullaniciId == kullaniciId).ToList();
        }
    }
}
