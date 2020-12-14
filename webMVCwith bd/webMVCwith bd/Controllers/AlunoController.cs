using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace webMVCwith_bd.Controllers
{
    public class AlunoController : Controller
    {
        // GET: Aluno
        public ActionResult CriaAluno()
        {
            return View();
        }
    }
}