using SchoolProyecto2.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace SchoolProyecto2.Controllers
{
    public class ColegiosController : Controller
    {
        // GET: Colegios
        private SchoolProjectEntities conexion = new SchoolProjectEntities();

        public ActionResult Index()
        {
            return View(conexion.Colegios.ToList());
        }

        // GET: cargoes/Details/5
        public ActionResult Details(int? idColegio)
        {
            if (idColegio == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SchoolProjectEntities colegio = conexion.Colegios.Find(idColegio);
            if (colegio == null)
            {
                return HttpNotFound();
            }
            return View(colegio);
        }

        // GET: cargoes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: cargoes/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "IdCargo,NombreCargo")] SchoolProjectEntities colegio)
        {
            if (ModelState.IsValid)
            {
                conexion.Colegios.Add(colegio);
                conexion.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(colegio);
        }

        // GET: cargoes/Edit/5
        public ActionResult Edit(int? idColegio)
        {
            if (idColegio == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SchoolProjectEntities colegio = conexion.Colegios.Find(idColegio);
            if (colegio == null)
            {
                return HttpNotFound();
            }
            return View(colegio);
        }

        // POST: cargoes/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "IdCargo,NombreCargo")] SchoolProjectEntities colegio)
        {
            if (ModelState.IsValid)
            {
                conexion.Entry(colegio).State = EntityState.Modified;
                conexion.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(colegio);
        }

        // GET: cargoes/Delete/5
        public ActionResult Delete(int? idColegio)
        {
            if (idColegio == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SchoolProjectEntities colegio = conexion.Colegios.Find(idColegio);
            if (colegio == null)
            {
                return HttpNotFound();
            }
            return View(colegio);
        }

        // POST: cargoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int idColegio)
        {
            SchoolProjectEntities colegio = conexion.Colegios.Find(idColegio);
            conexion.Colegios.Remove(colegio);
            conexion.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                conexion.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}