using System;
using System.Collections.Generic;

namespace KodluyoruzRehber
{
    public class Rehber
    {
        public List<Kisi> Kisiler
        {
            get;
            set;
        }

        public Dictionary<char, IEylem> Eylemler
        {
            get;
            set;
        }

        public IEylem Eylem
        {
            get;
            set;
        }

        public Durum Durum
        {
            get;
            set;
        }

        public void DemoOlustur()
        {
            Kisiler = new List<Kisi>()
            {
                new Kisi()
                {
                    Isim="Feyza",
                    Soyisim="Soyisim1",
                    Telefon = "0 500 000 00 01"
                },
                new Kisi()
                {
                    Isim="Kadir",
                    Soyisim="Soyisim2",
                    Telefon = "0 500 000 00 02"
                },
                new Kisi()
                {
                    Isim="Melih Can",
                    Soyisim="Soyisim3",
                    Telefon = "0 500 000 00 03"
                },
                new Kisi()
                {
                    Isim="Oğuz",
                    Soyisim="Soyisim4",
                    Telefon = "0 500 000 00 04"
                },
                new Kisi()
                {
                    Isim="Zeynep",
                    Soyisim="Soyisim5",
                    Telefon = "0 500 000 00 05"
                },
            };
            Eylemler = new Dictionary<char, IEylem>()
            {
                {'1', new Kayit() },
                {'2', new Sil() },
                {'3', new Guncelle() },
                {'4', new Listele() },
                {'5', new Ara() }
            };
        }

        public void Baslat()
        {
            do
            {
                switch (Durum)
                {
                    case Durum.EylemBulunamadi:
                        Console.WriteLine($"Eylem Bulunamadı!");
                        break;
                    case Durum.EylemHata:
                        Console.WriteLine($"{Eylem.Aciklama} işlemini yaparken hata oluştu!");
                        Durum = Durum.EylemListe;
                        break;
                    case Durum.Eylem:
                        try
                        {
                            Eylem.Calistir(Kisiler);
                            Durum = Durum.EylemListe;
                        }
                        catch (Exception)
                        {
                            Durum = Durum.EylemHata;
                        }
                        break;
                    case Durum.Cikis:
                        break;
                    default:
                        var keyInfo = EylemListele();
                        Console.WriteLine();
                        char karakter = keyInfo.KeyChar;
                        if (Eylemler.ContainsKey(karakter))
                        {
                            Eylem = Eylemler[karakter];
                            Durum = Durum.Eylem;
                        }
                        else
                        {
                            Durum = Durum.EylemBulunamadi;
                        }
                        break;
                }
            } while (true);
        }

        public ConsoleKeyInfo EylemListele()
        {
            Console.WriteLine("Lütfen yapmak istediğiniz işlemi seçiniz :)");
            Console.WriteLine("*******************************************");
            foreach (var eylem in Eylemler)
            {
                Console.WriteLine($"{eylem.Key}. {eylem.Value.Aciklama}");
            }
            Console.WriteLine();
            Console.Write("Eylem Seciniz: ");
            return Console.ReadKey();



        }
    }
}