using StokTakip.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StokTakip.Business.Abstract
{
    public interface IUrunService
    {
        List<Urun> GetAll();
        Urun GetById(int id);
    }
}
