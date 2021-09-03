namespace KodluyoruzRehber
{
    public class Kisi
    {
        public string Isim
        {
            get;
            set;
        }

        public string Soyisim
        {
            get;
            set;
        }

        public string Telefon
        {
            get;
            set;
        }
        public string IsimSoyisim { get => $"{Isim} {Soyisim}"; }
        public override string ToString()
        {
            return $"{Isim} {Soyisim} [{Telefon}]";
        }
    }
}