using Introducao.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Introducao.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            
            var pessoa = new Pessoa()
            {
                PessoaId = 3,
                Nome = "Fernando Lucas",
                Tipo = "Administrador 2"
            };

            return View(pessoa);
        }

        public ActionResult IndexViewData()
        {
            var pessoa = new Pessoa()
            {
                PessoaId = 1,
                Nome = "Fernando",
                Tipo = "Administrador"
            };

            ViewData["PessoaId"] = pessoa.PessoaId;
            ViewData["Nome"] = pessoa.Nome;
            ViewData["Tipo"] = pessoa.Tipo;

            return View();
        }

        public ActionResult IndexViewBag()
        {
           
            var pessoa = new Pessoa();
            pessoa.PessoaId = 2;
            pessoa.Nome = "Lucas";
            pessoa.Tipo = "Gerente";

            ViewBag.Id   = pessoa.PessoaId;
            ViewBag.Nome = pessoa.Nome;
            ViewBag.Tipo = pessoa.Tipo;
            
            return View();
        }

        [HttpPost]
        public ActionResult Lista(Pessoa pessoa)
        {
            return View(pessoa);
        }

        /*
        [HttpPost]
        public ActionResult Lista(Pessoa pessoa)
        {
            ViewData["PessoaId"] = pessoa.PessoaId;
            ViewData["Nome"] = pessoa.Nome;
            ViewData["Tipo"] = pessoa.Tipo;

            return View();
        }*/

        /* Usando FormCollection pega os names formulário
         [HttpPost]
         public ActionResult Lista(FormCollection form)
         {
             ViewData["PessoaId"] = form["PessoaId"];
             ViewData["Nome"] = form["Nome"];
             ViewData["Tipo"] = form["Tipo"];

             return View();
         }*/

    }
}