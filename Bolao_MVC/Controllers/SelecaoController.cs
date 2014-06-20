using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Bolao_MVC.Models;


namespace Bolao_MVC.Controllers
{
    [Authorize]
    public class SelecaoController : Controller
    {
        Contexto bd = new Contexto();
        //
        // GET: /Selecao/
        
        public ActionResult Index()
        {
            return View(bd.Selecoes);
        }

        //
        // GET: /Selecao/Details/5

        public ActionResult Details(int id)
        {
            return View(bd.Selecoes.Single(p => p.Id == id));
        }

        //
        // GET: /Selecao/Create
        
        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Selecao/Create

        [HttpPost]
        public ActionResult Create(Selecao selecao)
        {
            if (ModelState.IsValid)
            {
                bd.Selecoes.Add(selecao);
                bd.SaveChanges();
                return RedirectToAction("Index");
            }
            return View();
        }

        //
        // GET: /Selecao/Edit/5

        public ActionResult Edit(int id)
        {
            return View(bd.Selecoes.Single(p => p.Id == id));
        }

        //
        // POST: /Selecao/Edit/5

        [HttpPost]
        public ActionResult Edit(Selecao selecao)
        {
            if (ModelState.IsValid)
            {
                bd.Selecoes.Attach(selecao);
                bd.Entry<Selecao>(selecao).State = System.Data.EntityState.Modified;
                bd.SaveChanges();
                return RedirectToAction("Index");

            }

            return View();

        }

        //
        // GET: /Selecao/Delete/5

        public ActionResult Delete(int id)
        {
            return View(bd.Selecoes.Single(p => p.Id == id));
        }

        //
        // POST: /Selecao/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfimado(int id)
        {
            bd.Selecoes.Remove(bd.Selecoes.Single(p => p.Id == id));
            return RedirectToAction("Index");


        }
    }
}
