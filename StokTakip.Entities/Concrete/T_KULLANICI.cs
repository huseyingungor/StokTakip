using StokTakip.Core.Entities;
using System;

namespace StokTakip.Entities.Concrete
{
    public class T_KULLANICI : IEntity
    {
        public int ID { get; set; }
        public string ADI { get; set; }
        public string SOYADI { get; set; }
        public string KULLANICI_ADI { get; set; }
        public string SIFRE { get; set; }
        public string EMAIL { get; set; }
        public T_KULLANICI_TIPI KULLANICI_TIPI{ get; set; }
        public DateTime KAYIT_TARIHI { get; set; }
        public DateTime GUNCELLEME_TARIHI { get; set; }
        public bool AKTIF_MI { get; set; }
    }
}
