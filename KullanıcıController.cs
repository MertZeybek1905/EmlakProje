using EmlakProje.Data;
using EmlakProje.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmlakProje.Controllers
{
    public class KullanıcıController : Controller
    {
        private readonly EmlakDbContext _emlak;
        public KullanıcıController(EmlakDbContext emlak)
        {
            _emlak = emlak;
        }
        //Kullanıcı Giriş
        public IActionResult Add()
        {
            return View();
        }
        //Kullanıcı Giriş
        [HttpPost]
        public IActionResult Add(KayıtBilgi kayıt)
        {

            var login = _emlak.Bilgiler.FirstOrDefault(k => k.Password == kayıt.Password);
            if (login!=null)
            {
                return View("Anasayfa");
            }
            return View();
        }
        //İlan Ekleme
        [HttpGet]
        public IActionResult HomeAdd()
        {
            return View();
        }
        //İlan Ekleme
        [HttpPost]
        public IActionResult HomeAdd(İlanlar ilanlar)
        {
            _emlak.İlanBilgi.Add(ilanlar);
            _emlak.SaveChanges();
            return View();
        }
        //İlan Listeleme
        public IActionResult List()
        {
            //var ilan = new İlanlar();
            //ilan.Kira = 5;
            return View();
        }
        //İlan Listeleme
        [HttpPost]
        public IActionResult List(int id)
        {

            var goster = _emlak.İlanBilgi.FirstOrDefault(i => i.EkleyenId == id);
            if (goster!= null)
            {
                return View(goster);
            }


            return View("göster2");
        }
        //İlan Güncelleme
        [HttpGet]
        public IActionResult HomeUpdate()
        {

            return View();
        }
        //İlan Güncelleme
        [HttpPost]
        public IActionResult HomeUpdate(İlanlar ilanlar)
        {
            İlanlar ilangüncelle = _emlak.İlanBilgi.FirstOrDefault(p => p.EvId == ilanlar.EvId);
            ilangüncelle.Kira = ilanlar.Kira;
            _emlak.Update(ilangüncelle);
            _emlak.SaveChanges();
            return View();
        }
        //Şifre Güncelleme
        [HttpGet]
        public IActionResult ChangePassword()
        {
            return View();
        }
        //Şifre Güncelleme
        [HttpPost]
        public IActionResult ChangePassword(KayıtBilgi kayıtBilgi)
        {
            KayıtBilgi güncelle = _emlak.Bilgiler.SingleOrDefault(p => p.UserName == kayıtBilgi.UserName);
            güncelle.Password = kayıtBilgi.Password;
            _emlak.Update(güncelle);
            _emlak.SaveChanges();
            return View();
        }

        public IActionResult List1()
        {
            //var ilan = new İlanlar();
            //ilan.Kira = 5;
            return View();
        }

    }
}
