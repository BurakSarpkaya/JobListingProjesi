﻿using JobListingProjesi.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobListingProjesi.Bll
{
    public class BasvuruRepository:BaseRepository<Basvuru>
    {
        public List<Basvuru> IlaninBasvurulariniGetir(int ilanId)
        {
            return context.Basvuru.Where(x => x.IlanId == ilanId).ToList();
        }
    }
}
