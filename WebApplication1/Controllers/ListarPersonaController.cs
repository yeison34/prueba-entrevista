using System;
using System.Collections.Generic;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Data;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class ListarPersonaController : Controller
    {
        public ActionResult Index()
        {
            List<PersonaModel> lista = new List<PersonaModel>();
            try {
                lista = PersonaData.listarpersonas();
            }catch(Exception ex)
            {

            }
            return View(lista);
        }
    }
}
