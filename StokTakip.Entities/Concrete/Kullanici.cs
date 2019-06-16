using StokTakip.Core.Entities;
using System;

namespace StokTakip.Entities.Concrete
{
    public class Kullanici : IEntity
    {
        public int ID { get; set; }
        public string ADI { get; set; }
        public string SOYADI { get; set; }
        public string KULLANICI_ADI { get; set; }
        public string SIFRE { get; set; }
        public string EMAIL { get; set; }
        public KullaniciTipi KULLANICI_TIPI{ get; set; }
        public DateTime KAYIT_TARIHI { get; set; }
        public DateTime GUNCELLEME_TARIHI { get; set; }
        public bool AKTIF_MI { get; set; }
    }
}
