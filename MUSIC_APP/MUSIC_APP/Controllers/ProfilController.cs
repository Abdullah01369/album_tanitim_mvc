using Businness_Layer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MUSIC_APP.Controllers
{
    public class ProfilController : Controller
    {
        Kullanicilar_Services ks = new Kullanicilar_Services();
        public ActionResult Index()
        {
            return View();
        }

        public PartialViewResult kullaniciadigonder()  // PARTİAL İLE OTURUMM ACAN KISININ BİLGİSİ LAYOUTA TAŞINDI ---> PROFİLLAYOUT
        {
            var mail = (string)Session["Kullanıcı_Mail"];
            var veri = ks.Kullanici_Bilgi_Gonder(mail);
            ViewBag.ad_soyad = veri.Kullanıcı_Ad + " " + veri.Kullanıcı_Soyad;
            return PartialView();
        }
    }
}