using System.Collections.Generic;

namespace KodluyoruzRehber
{
    public interface IEylem
    {
        string Aciklama { get; set; }

        void Calistir(List<Kisi> kisiler);
    }
}