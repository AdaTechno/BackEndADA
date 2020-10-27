using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using JapanoriWebSystem.DAL;
using JapanoriWebSystem.Models;

namespace JapanoriWebSystem.Controllers
{
    public class ComandaController : Controller
    {
#pragma warning disable IDE0044 // Adicionar modificador somente leitura
        private JapanoriContext db = new JapanoriContext();
#pragma warning restore IDE0044 // Adicionar modificador somente leitura

        // GET: Comanda
        public ActionResult Index()
        {
            Database.SetInitializer(new DropCreateDatabaseAlways<JapanoriContext>());
            return View(db.Comandas.ToList());
        }

        // GET: Comanda/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Comanda comanda = db.Comandas.Find(id);
            if (comanda == null)
            {
                return HttpNotFound();
            }
            return View(comanda);
        }

        // GET: Comanda/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Comanda/Create
        // Para proteger-se contra ataques de excesso de postagem, ative as propriedades específicas às quais deseja se associar. 
        // Para obter mais detalhes, confira https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Situacao,Status")] Comanda comanda)
        {
            if (ModelState.IsValid)
            {
                db.Comandas.Add(comanda);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(comanda);
        }

        // GET: Comanda/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Comanda comanda = db.Comandas.Find(id);
            if (comanda == null)
            {
                return HttpNotFound();
            }
            return View(comanda);
        }

        // POST: Comanda/Edit/5
        // Para proteger-se contra ataques de excesso de postagem, ative as propriedades específicas às quais deseja se associar. 
        // Para obter mais detalhes, confira https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Situacao,Status")] Comanda comanda)
        {
            if (ModelState.IsValid)
            {
                db.Entry(comanda).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(comanda);
        }

        // GET: Comanda/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Comanda comanda = db.Comandas.Find(id);
            if (comanda == null)
            {
                return HttpNotFound();
            }
            return View(comanda);
        }

        // POST: Comanda/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Comanda comanda = db.Comandas.Find(id);
            db.Comandas.Remove(comanda);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
