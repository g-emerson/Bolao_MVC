﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Bolao_MVC.Models;


namespace Bolao_MVC.Controllers
{
    [Authorize]
    public class JogoController : Controller
    {
        Contexto bd = new Contexto();
        //
        // GET: /Jogo/

        public ActionResult Index()
        {
            return View(bd.Jogos);
        }

        //
        // GET: /Jogo/Details/5

        public ActionResult Details(int id)
        {
            return View(bd.Jogos.Single(p => p.Id == id));
        }

        //
        // GET: /Jogo/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Jogo/Create

        [HttpPost]
        public ActionResult Create(Jogo jogo)
        {
            if (ModelState.IsValid)
            {
                bd.Jogos.Add(jogo);
                bd.SaveChanges();
                return RedirectToAction("Index");
            }
            return View();
        }

        //
        // GET: /Jogo/Edit/5

        public ActionResult Edit(int id)
        {
            return View(bd.Jogos.Single(p => p.Id == id));
        }

        //
        // POST: /Jogo/Edit/5

        [HttpPost]
        public ActionResult Edit(Jogo jogo)
        {
            if (ModelState.IsValid)
            {
                bd.Jogos.Attach(jogo);
                bd.Entry<Jogo>(jogo).State = System.Data.EntityState.Modified;
                bd.SaveChanges();
                return RedirectToAction("Index");

            }

            return View();

        }

        //
        // GET: /Jogo/Delete/5

        public ActionResult Delete(int id)
        {
            return View(bd.Jogos.Single(p => p.Id == id));
        }

        //
        // POST: /Jogo/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfimado(int id)
        {
            bd.Jogos.Remove(bd.Jogos.Single(p => p.Id == id));
            return RedirectToAction("Index");


        }
    }
}
