using JqueryDataTable.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace JqueryDataTable.Controllers
{
    public class TrabalhadoresController : Controller
    {
        // GET: Trabalhadores
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult GetList()
        {
            var trabalhadores = GetListTrabalhador();
            //https://www.youtube.com/watch?v=u147Q0NY6Qg&list=PLjC4UKOOcfDQl-5j8RIWoODQf34ofmc0Y&index=1
            return Json(new { data = trabalhadores }, JsonRequestBehavior.AllowGet);
        }

        public IEnumerable<Trabalhador> GetListTrabalhador()
        {
            List<Trabalhador> trbalhador = new List<Trabalhador>() { 
            new Trabalhador(){ Id = 1, Name = "Filipe", Position="TI",Salary=2500,
            Age=28},
            new Trabalhador(){ Id = 2, Name = "aaaa", Position="TI",Salary=2500,
            Age=28},
            new Trabalhador(){ Id = 3, Name = "bbb", Position="TI",Salary=2500,
            Age=28},
            new Trabalhador(){ Id = 4, Name = "dsfsdff", Position="financeiro",Salary=2500,
            Age=28},
            new Trabalhador(){ Id = 5, Name = "augsto", Position="financeiro",Salary=2500,
            Age=28},
            new Trabalhador(){ Id = 6, Name = "satnhos", Position="financeiro",Salary=2500,
            Age=28},
            new Trabalhador(){ Id = 7, Name = "filipinho", Position="financeiro",Salary=2500,
            Age=28},
            new Trabalhador(){ Id = 8, Name = "augustao", Position="TI",Salary=2500,
            Age=28},
            new Trabalhador(){ Id = 9, Name = "são Filipe", Position="operacional",Salary=2000,
            Age=28},
            new Trabalhador(){ Id = 10, Name = "joão filipe", Position="TI",Salary=2000,
            Age=28},
            new Trabalhador(){ Id = 11, Name = "ze felipe", Position="operacional",Salary=2500,
            Age=28},
            new Trabalhador(){ Id = 12, Name = "Filipa", Position="TI",Salary=5500,
            Age=28},
            new Trabalhador(){ Id = 13, Name = "maria Filipa", Position="TI",Salary=8500,
            Age=28},
            new Trabalhador(){ Id = 14, Name = "dona filipa", Position="TI",Salary=7500,
            Age=28},
            new Trabalhador(){ Id = 15, Name = "Don Filipes", Position="operacional",Salary=800,
            Age=28},
            new Trabalhador(){ Id = 16, Name = "Sr Filipe", Position="TI",Salary=1300,
            Age=28},
            new Trabalhador(){ Id = 17, Name = "chaves", Position="ToperacionalI",Salary=1400,
            Age=28},
            new Trabalhador(){ Id = 18, Name ="mario chaves", Position="TI",Salary=1500,
            Age=28},
            new Trabalhador(){ Id = 19, Name = "ze chaves", Position="operacional",Salary=2500,
            Age=28},
            new Trabalhador(){ Id = 20, Name = "jose santos", Position="financeiro",Salary=1500,
            Age=28},
            new Trabalhador(){ Id = 21, Name = "dona santas", Position="operacional",Salary=2500,
            Age=28},


            };
            return trbalhador;
        }
    }
}