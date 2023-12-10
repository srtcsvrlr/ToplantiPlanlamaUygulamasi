﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToplantiPlanlamaUygulamasi
{
    public class Toplanti
    {
        public Toplanti() {
            Baslik = "Toplanti-1";           
        }

        public string Baslik { get; set; }
        public string Aciklama { get; set; }
        public string ToplantiKodu { get; set; }
        public string ToplantiTarihi { get; set; }
        
        public List<string> KatilimciListesi { get; set; }

        public List<DateTime> UygunToplantiTarihleri { get; set; }

    }
}