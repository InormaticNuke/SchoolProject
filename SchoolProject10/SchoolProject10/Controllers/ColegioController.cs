using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SchoolProject10.Controllers
{
    public class ColegioController : Controller
    {
        SchoolProjectEntities conexion = new SchoolProjectEntities();
        public ActionResult Index()
        {

            var lista = conexion.Colegio.ToList();
            return View(lista);
        }

        public ActionResult Details(int? IdColegio)
        {
            if (IdColegio == null)
            {
                return HttpNotFound();
            }
            ColegioController colegio = conexion.Colegio.Find(IdColegio);

            if (colegio == null)
            {
                return HttpNotFound();
            }
            return View(colegio);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create([Bind(Include = "IdLocal,NombreLocal,Direccion,Telefono")] ColegioController colegio)
        {
            if (!ModelState.IsValid)
            {
                conexion.Colegio.Add(colegio);
                conexion.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(colegio);
        }

        public ActionResult Edit(int? IdColegio)
        {
            if (IdColegio == null)
            {
                return HttpNotFound();
            }
            ColegioController colegio = conexion.Colegio.Find(IdColegio);

            if (colegio == null)
            {
                return HttpNotFound();
            }
            return View(colegio);
        }

        public ActionResult Edit([Bind(Include = "IdLocal,NombreLocal,Direccion,Telefono")] ColegioController colegio)
        {
            if (ModelState.IsValid)
            {
                conexion.Entry(colegio).State = EntityState.Modified;
                conexion.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(colegio);
        }

        public ActionResult Delete(int? IdColegio)
        {
            if (IdColegio == null)
            {
                return HttpNotFound();
            }
            ColegioController colegio = conexion.Colegio.Find(IdColegio);

            if (colegio == null)
            {
                return HttpNotFound();
            }
            return View(colegio);
        }

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int IdColegio)
        {
            ColegioController colegio = conexion.Colegio.Find(IdColegio);
            conexion.Colegio.Remove(colegio);
            conexion.SaveChanges();
            return RedirectToAction("Index");
        }


    }
}
}