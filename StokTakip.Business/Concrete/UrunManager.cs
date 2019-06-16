using StokTakip.Business.Abstract;
using StokTakip.Core.Entities;
using StokTakip.DataAccess.Abstract;
using StokTakip.Entities.Concrete;
using StokTakip.Entities.Other;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StokTakip.Business.Concrete
{
    public class UrunManager : IUrunService
    {
        private IUrunDal _urunDal;

        public UrunManager(IUrunDal urunDal)
        {
            _urunDal = urunDal;
        }

        public List<Urun> GetAll()
        {
            return _urunDal.GetList();
        }

        public Urun GetById(int id)
        {
            return _urunDal.Get(x => x.ID == id);
        }

        public IslemSonuc UrunSil(int id)
        {
            IslemSonuc sonuc = new IslemSonuc();

            var urun = _urunDal.Get(x => x.ID == id);

            if (urun == null)
            {
                sonuc.Tur = IslemSonucTur.Hatali;
                sonuc.Aciklama = "Silmek istediğiniz ürün bulunamadı.";
            }
            else
            {
                _urunDal.Delete(urun);
                sonuc.Tur = IslemSonucTur.Basarili;
                sonuc.Aciklama = "Ürün silindi";
            }

            return sonuc;
        }
    }
}
