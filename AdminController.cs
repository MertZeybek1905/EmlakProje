using EmlakProje.Data;
using EmlakProje.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmlakProje.Controllers
{
    public class AdminController : Controller
    {
        private readonly EmlakDbContext _emlak;
        public AdminController(EmlakDbContext emlak)
        {
            _emlak = emlak;
        }
        //Emlakçı Ekleme
        [HttpGet]
        public IActionResult Add()
        {
            //List<KayıtBilgi> kayıtBilgi = new List<KayıtBilgi>();
            //try
            //{
            //    kayıtBilgi = _emlak.Bilgiler.ToList();
            //}
            //catch(Exception)
            //{

            //}
            //return View(kayıtBilgi);
            return View();
        }
        //Emlakçı Ekleme
        [HttpPost]
        public IActionResult Add(KayıtBilgi kayıtBilgi)
        {
            _emlak.Add(kayıtBilgi);
            _emlak.SaveChanges();
            return View("AnaSayfa");
        }
    }
}
