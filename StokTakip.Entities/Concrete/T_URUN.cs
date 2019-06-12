using StokTakip.Core.Entities;
using System;

namespace StokTakip.Entities.Concrete
{
    public class T_URUN:IEntity
    {
        public int ID { get; set; }
        public string ADI { get; set; }
        public string ACIKLAMA { get; set; }
        public int STOK { get; set; }
        public decimal FIYAT { get; set; }
        public DateTime KAYIT_TARIHI { get; set; }
        public DateTime GUNCELLEME_TARIHI { get; set; }
        public bool AKTIF_MI { get; set; }
    }
}
