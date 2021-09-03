using System;
using System.Collections.Generic;

namespace KodluyoruzRehber
{
    public class Listele : IEylem
    {
        public string Aciklama { get; set; } = "Rehberi Listelemek";

        public void Calistir(List<Kisi> kisiler)
        {
            throw new NotImplementedException();
        }
    }
}