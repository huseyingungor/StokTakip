using Microsoft.EntityFrameworkCore;
using StokTakip.Entities.Concrete;

namespace StokTakip.DataAccess.Concrete.EntityFramework
{
    public class StokTakipContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=HGUNGOR\SQLEXPRESS;Database=STOK_TAKIP; Trusted_Connection=True");
        }

        DbSet<Kullanici> T_KULLANICI { get; set; }
        DbSet<KullaniciTipi> T_KULLANICI_TIPI { get; set; }
        DbSet<Urun> T_URUN { get; set; }
    }
}
