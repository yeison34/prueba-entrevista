using System;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Data;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class PruebaController : Controller
    {

        [HttpPost]
        public ActionResult Index(PersonaModel persona) {
            try {
                PersonaData.guardar(persona);
            }
            catch (Exception ex) { 
            }
            return View();
        }

        [HttpGet]
        public ActionResult Index() {
            return View();
        }

        
    }
}
