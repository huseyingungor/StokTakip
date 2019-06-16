using StokTakip.Core.DataAccess.EntityFramework;
using StokTakip.DataAccess.Abstract;
using StokTakip.Entities.Concrete;

namespace StokTakip.DataAccess.Concrete.EntityFramework
{
    public class EfKullaniciTipiDal : EfEntityRepositoryBase<KullaniciTipi, StokTakipContext>, IKullaniciTipiDal
    {
    }
}
