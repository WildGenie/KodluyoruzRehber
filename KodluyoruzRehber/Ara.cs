using System;
using System.Collections.Generic;

namespace KodluyoruzRehber
{
    public class Ara : IEylem
    {
        public string Aciklama { get; set; } = "Rehberde Arama Yapmak";

        public void Calistir(List<Kisi> kisiler)
        {
            throw new NotImplementedException();
        }
    }
}