using Introducao.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Introducao.Controllers
{
    public class UsuarioController : Controller
    {
        // GET: Usuario
        public ActionResult Index()
        {
            var usuario = new Usuario();
            return View(usuario);
        }

        [HttpPost]
        public ActionResult Index(Usuario usuario)
        {
            if (string.IsNullOrEmpty(usuario.Nome))
            {
                ModelState.AddModelError("Nome", "O Campo 'Nome' é de preenchimento obrigatório");
            }
            if (ModelState.IsValid)
            {
                return View("Resultado", usuario);
            }
            return View(usuario);
        }


        public ActionResult Resultado(Usuario usuario)
        {
            return View(usuario);
        }
    }
}