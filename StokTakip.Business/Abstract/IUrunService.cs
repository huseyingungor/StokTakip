using StokTakip.Entities.Concrete;
using StokTakip.Entities.Other;
using System.Collections.Generic;

namespace StokTakip.Business.Abstract
{
    public interface IUrunService
    {
        List<Urun> GetAll();
        Urun GetById(int id);
        IslemSonuc UrunSil(int id);
    }
}
