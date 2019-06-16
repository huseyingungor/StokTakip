using StokTakip.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StokTakip.Entities.Concrete
{
    public class KullaniciTipi : IEntity
    {
        public int ID { get; set; }
        public string ROL_ADI { get; set; }
        public DateTime KAYIT_TARIHI { get; set; }
        public DateTime GUNCELLEME_TARIHI { get; set; }
        public bool AKTIF_MI { get; set; }
    }
}
