using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Aprendiendo.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.MiListado = ObtenerListado();
            return View();
        }


        public List<SelectListItem> ObtenerListado()
        {
            return new List<SelectListItem>() {

                new SelectListItem()
                {
                    Text = "Si",
                    Value = "1"
                },


                new SelectListItem()
                {
                    Text = "No",
                    Value = "2"
                },
                new SelectListItem()
                {
                    Text = "Quizas",
                    Value = "3",

                }
            };
        }

            

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}