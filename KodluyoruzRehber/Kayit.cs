using System;
using System.Collections.Generic;

namespace KodluyoruzRehber
{
    public class Kayit : IEylem
    {
        public string Aciklama { get; set; } = "Yeni Numara Kaydetmek";

        public void Calistir(List<Kisi> kisiler)
        {
            throw new NotImplementedException();
        }
    }
}