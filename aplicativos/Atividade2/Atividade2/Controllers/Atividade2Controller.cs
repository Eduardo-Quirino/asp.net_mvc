﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Atividade2.Controllers
{
    public class Atividade2Controller : Controller
    {
        // GET: Atividade2
        public ActionResult Index()
        {
            ViewData["Nome"] = "Eduardo Quirino";
            ViewBag.Atividade = "Atividade 2";
            ViewBag.Cuso = "Curso ASP .NET MVC 5";

            return View();
        }
    }
}