using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Bolao_MVC.Models;


namespace Bolao_MVC.Controllers
{
    [Authorize]
    public class GrupoController : Controller
    {
        Contexto bd = new Contexto();
        //
        // GET: /Grupo/

        public ActionResult Index()
        {
            return View(bd.Grupos);
        }

        //
        // GET: /Grupo/Details/5

        public ActionResult Details(int id)
        {
            return View(bd.Grupos.Single(p => p.Id == id));
        }

        //
        // GET: /Grupo/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Grupo/Create

        [HttpPost]
        public ActionResult Create(Grupo grupo)
        {
            if (ModelState.IsValid)
            {
                bd.Grupos.Add(grupo);
                bd.SaveChanges();
                return RedirectToAction("Index");
            }
            return View();
        }

        //
        // GET: /Grupo/Edit/5

        public ActionResult Edit(int id)
        {
            return View(bd.Grupos.Single(p => p.Id == id));
        }

        //
        // POST: /Grupo/Edit/5

        [HttpPost]
        public ActionResult Edit(Grupo grupo)
        {
            if (ModelState.IsValid)
            {
                bd.Grupos.Attach(grupo);
                bd.Entry<Grupo>(grupo).State = System.Data.EntityState.Modified;
                bd.SaveChanges();
                return RedirectToAction("Index");

            }

            return View();

        }

        //
        // GET: /Grupo/Delete/5

        public ActionResult Delete(int id)
        {
            return View(bd.Grupos.Single(p => p.Id == id));
        }

        //
        // POST: /Grupo/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfimado(int id)
        {
            bd.Grupos.Remove(bd.Grupos.Single(p => p.Id == id));
            return RedirectToAction("Index");            
        }
    }
}
