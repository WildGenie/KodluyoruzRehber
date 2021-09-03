using System;
using System.Collections.Generic;

namespace KodluyoruzRehber
{
    public class Guncelle : IEylem
    {
        public string Aciklama { get; set; } = "Varolan Numarayı Güncelleme";

        public void Calistir(List<Kisi> kisiler)
        {
            throw new NotImplementedException();
        }
    }
}