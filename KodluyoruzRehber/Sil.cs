using System;
using System.Collections.Generic;

namespace KodluyoruzRehber
{
    public class Sil : IEylem
    {
        public string Aciklama { get; set; } = "Varolan Numarayı Silmek";

        public void Calistir(List<Kisi> kisiler)
        {
            throw new NotImplementedException();
        }
    }
}