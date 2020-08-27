using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using FluxoCaixa03.Models;

namespace FluxoCaixa03.Controllers
{
    public class FcclassesController : Controller
    {
        public IActionResult Index()
        {

            List<Fcclasse> list = new List<Fcclasse>();

            list.Add(new Fcclasse { id_classe = 1, nm_classe = "Transporte" });
            list.Add(new Fcclasse { id_classe = 2, nm_classe = "Alimentação" });

            return View(list);
        }
    }
}
