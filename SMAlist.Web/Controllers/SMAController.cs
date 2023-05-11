using Microsoft.AspNetCore.Mvc;
using SMAlist.Web.Models;

namespace SMAlist.Web.Controllers
{
    public class SMAController : Controller
    {
        private AppDbContext _context;
        public SMAController(AppDbContext context)
        {
            _context = context;          
        }
        //ANA SAYFADA VERİ TABANINDAKİ ÇOCUKLARI LİSTELER
        public IActionResult Index()
        {
            var listele = _context.SMA.ToList();
            return View(listele);
        }
//TIKLADIKTAN SONRA DETAYLI BİLGİYİ GÖSTERİR.
        public IActionResult Detay(int id)
        {
            var bul = _context.SMA.Find(id);
            return View(bul);
        }

        //FORM SAYFASINA GİDER
        public IActionResult Form()
        {
            return View();
        }
        //FORMA GİRİLEN VERİLERİ BURAYA GÖNDERİR BURADAN DA VERİ TABANINA KAYDOLUR.
        [HttpPost]
        public IActionResult Form(Form newForm)
        {
            _context.SMA_Form.Add(newForm);
            _context.SaveChanges();
            TempData["status"] = "FORM GÖNDERİLDİ";
            return RedirectToAction("Form");
        }

        //SMA NEDİR SAYFASI
        public IActionResult NedirSMA()
        {
            return View();
        }
    }
}
