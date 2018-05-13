using Introducao.Models;
using System.Collections.ObjectModel;
using System.Linq;
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
            /*if (string.IsNullOrEmpty(usuario.Nome))
            {
                ModelState.AddModelError("Nome", "O Campo 'Nome' é de preenchimento obrigatório");
            }
            if (usuario.Senha != usuario.ConfirmaSenha)
            {
                ModelState.AddModelError("", "As senhas são diferentes");
            }*/
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

        public ActionResult LoginUnico(string login)
        {
            var bdExemplo = new Collection<string> {
                "Fernando",
                "Pedro",
                "Paula"
            };

            return Json(bdExemplo.All(x => x.ToLower() != login.ToLower()), JsonRequestBehavior.AllowGet);
        }
    }
}