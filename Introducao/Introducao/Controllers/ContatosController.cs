﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Introducao.Controllers
{
    public class ContatosController : Controller
    {
        // GET: Contatos
        public ActionResult Index()
        {
            return View();
        }
    }
}