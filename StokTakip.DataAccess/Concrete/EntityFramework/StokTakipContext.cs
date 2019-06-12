using Microsoft.EntityFrameworkCore;
using StokTakip.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StokTakip.DataAccess.Concrete.EntityFramework
{
    public class StokTakipContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=HGUNGOR\SQLEXPRESS; Database=STOK_TAKIP; Trusted_Connection=True");
        }

        DbSet<T_KULLANICI> Kullanicilar { get; set; }
        DbSet<T_KULLANICI_TIPI> KullaniciTipleri { get; set; }
        DbSet<T_URUN> Urunler { get; set; }
    }
}
