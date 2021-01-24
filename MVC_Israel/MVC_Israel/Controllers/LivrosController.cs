using MVC_Israel.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Israel.Controllers
{
    public class LivrosController : Controller
    {
        // GET: Livro
        public ActionResult Index()
        {
            List<Livros> livros = new List<Livros>();
             return View(livros);
        }
        public ActionResult Create()
        {
            return View();
        }

        public ActionResult Edit()
        {
            return View();
        }

        public ActionResult Delete()
        {
            return View();
        }

    }
}