using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel;
using WebUsinagem.Data;
using WebUsinagem.Models;

namespace WebUsinagem.Controllers
{
    public class RegistroController : Controller
    {
        private readonly ApplicationDbContext _db;

        public RegistroController(ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult RegistroList()
        {
           List<Registro> objRegistroList = _db.Registros.ToList();
            return View(objRegistroList);
        }

        [HttpPost]
        public IActionResult Index(Registro obj)
        {
            if (ModelState.IsValid)
            {
                _db.Registros.Add(obj);
                _db.SaveChanges();
                return RedirectToAction("Index", "Home");
            }
            return View();
        }
    }
}
