using System;
using System.Collections.Generic;

namespace KodluyoruzRehber
{
    public class Kayit : IEylem
    {
        public string Aciklama { get; set; } = "Yeni Numara Kaydetmek";

        public void Calistir(List<Kisi> kisiler)
        {
            var kisi = new Kisi();
            Console.Write("Lütfen isim giriniz             :");
            kisi.Isim = Console.ReadLine();
            Console.Write("Lütfen soyisim giriniz          :");
            kisi.Soyisim = Console.ReadLine();
            Console.Write("Lütfen telefon numarası giriniz :");
            kisi.Telefon = Console.ReadLine();
            kisiler.Add(kisi);

        }
    }
}