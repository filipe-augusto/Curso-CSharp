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
        livrariaEntities livraria = new livrariaEntities();
        
        // GET: Livro
        public ActionResult Index()
        {
            List<Livros> livros = new List<Livros>();
            var LivrosBanco = livraria.Livro.ToList();


            System.Collections.IList list = LivrosBanco;
            for (int i = 0; i < list.Count; i++)
            {
                Livro item = (Livro)list[i];
                Livros liv = new Livros();
                liv.IdLivro = item.IdLivro;
                liv.Nome = item.Nome;
                liv.Editora = item.IdEditora;
                liv.Genero = item.IdGenero;
               // liv.Autores.Nome = item.Autor.Nome;
                liv.QuantidadePaginas = item.QuantidadePaginas;
                liv.DataCadastro = DateTime.Now;
                liv.Classificacao = item.Classificacao;
                livros.Add(liv);
            }



            return View(livros);
        }
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Livros livros)
        {
            Livro liv = new Livro();
            liv.IdLivro = livros.IdLivro;
            liv.Nome = livros.Nome;
            liv.IdEditora = livros.Editora;
            liv.IdGenero = livros.Genero ;
            liv.Classificacao = livros.Classificacao;
            liv.DataCadastro = livros.DataCadastro;
            
            livraria.Livro.Add(liv);
            livraria.SaveChanges();

            return RedirectToAction("Index");
        }

        public ActionResult Edit(int idLivro)
        {
            var livro = livraria.Livro.Where(a => a.IdLivro == idLivro).FirstOrDefault();//bd
            Livros liv = new Livros();
            // Autores autores = new Autores();//model
            liv.IdLivro = livro.IdLivro;
            liv.Nome = livro.Nome;
            liv.Genero = livro.IdGenero;
            liv.Editora = livro.IdEditora;
            liv.DataCadastro = DateTime.Now;
            liv.QuantidadePaginas = livro.QuantidadePaginas;
            liv.Classificacao = livro.Classificacao;
            return View(liv);
        }

        [HttpPost]
        public ActionResult Edit(Livros livros)
        {
            var liv = livraria.Livro.Where(a => a.IdLivro == livros.IdLivro).FirstOrDefault();
            liv.IdLivro = livros.IdLivro;
            liv.Nome = livros.Nome;
            liv.DataCadastro = livros.DataCadastro;
            liv.IdEditora = livros.Editora;
            liv.IdGenero = livros.Genero;
            liv.Classificacao = livros.Classificacao;
            liv.IdAutor = 1;
            liv.QuantidadePaginas = livros.QuantidadePaginas;
            livraria.SaveChanges();

            return RedirectToAction("Index");
        }


        public ActionResult Delete()
        {
            return View();
        }

    }
}