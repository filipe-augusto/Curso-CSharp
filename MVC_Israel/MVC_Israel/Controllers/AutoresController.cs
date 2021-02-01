using MVC_Israel.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Israel.Controllers
{
    public class AutoresController : Controller
    {
        livrariaEntities livraria = new livrariaEntities();

        // GET: Autor
        public ActionResult Index()
        {
            List<Autores> Listautores = new List<Autores>();
            var AutoresBanco = livraria.Autor.ToList();

            foreach(Autor item in AutoresBanco)
            {
                Autores autores = new Autores();
                autores.IdAutor = item.IdAutor;
                autores.Nome = item.Nome;
                autores.Pais = item.Pais;

                Listautores.Add(autores);
            }

            return View(Listautores);
        }
        public ActionResult Create()
        {
            return View();
        }



        [HttpPost]
        public ActionResult Create(Autores autores)
        {
          //  byte id_autor = byte.Parse((DateTime.Now.Millisecond/10));
            Autor autor = new Autor();
            autor.IdAutor = 10;
            autor.Nome = autores.Nome;
            autor.Pais = autores.Pais;
            livraria.Autor.Add(autor);
            livraria.SaveChanges();

            return RedirectToAction("Index");
        }

        public ActionResult Edit(int IdAutor)
        {
            var Autor = livraria.Autor.Where(a => a.IdAutor == IdAutor).FirstOrDefault();//bd

            Autores autores = new Autores();//model
            autores.IdAutor = Autor.IdAutor;
            autores.Nome = Autor.Nome;
            autores.Pais = Autor.Pais;
            return View(autores);
        }

        [HttpPost]
        public ActionResult Edit(Autores autores)
        {
            var autor = livraria.Autor.Where(a => a.IdAutor == autores.IdAutor).FirstOrDefault();
            autor.Nome = autores.Nome;
            autor.Pais = autores.Pais;
            livraria.SaveChanges();

            return RedirectToAction("Index");
        }


        public ActionResult Delete(int IdAutor)
        {
            var Autor = livraria.Autor.Where(a => a.IdAutor == IdAutor).FirstOrDefault();//bd
            Autores autores = new Autores();//model
            autores.IdAutor = Autor.IdAutor;
            autores.Nome = Autor.Nome;
            autores.Pais = Autor.Pais;
            return View(autores);
        }

        [HttpPost]
        public ActionResult Delete(Autores autores)
        {
            var autor = livraria.Autor.Where(a => a.IdAutor == autores.IdAutor).FirstOrDefault();
            autor.Nome = autores.Nome;
            autor.Pais = autores.Pais;
            livraria.Autor.Remove(autor);
            livraria.SaveChanges();

            return RedirectToAction("Index");
        }


    }
}