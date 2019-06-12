using StokTakip.Core.DataAccess.EntityFramework;
using StokTakip.DataAccess.Abstract;
using StokTakip.Entities.Concrete;

namespace StokTakip.DataAccess.Concrete.EntityFramework
{
    public class EfKullaniciTipiDal : EfEntityRepositoryBase<T_KULLANICI_TIPI, StokTakipContext>, IKullaniciTipiDal
    {
    }
}
