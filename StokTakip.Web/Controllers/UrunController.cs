using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using StokTakip.Business.Abstract;
using StokTakip.Web.Models;

namespace StokTakip.Web.Controllers
{
    public class UrunController : Controller
    {
        private IUrunService _urunService;

        public UrunController(IUrunService urunService)
        {
            _urunService = urunService;
        }

        public IActionResult Index()
        {
            return View(new UrunListViewModel
            {
                Urunler = _urunService.GetAll()
            });
        }

        public IActionResult Index2()
        {
            var moddel = _urunService.GetById(1);
            return View(moddel);
        }
    }
}