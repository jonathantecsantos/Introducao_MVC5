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
        public ActionResult Usuario()
        {
            var usuario = new Usuario();
            return View(usuario);
        }

        [HttpPost]
        public ActionResult Usuario (Usuario usuario)
        {
            if (ModelState.IsValid)
            {
                return View("Resultado",usuario);
            }
            return View(usuario);
        }
        public ActionResult Resultado(Usuario usuario)
        {
            return View(usuario);
        }
    }
}