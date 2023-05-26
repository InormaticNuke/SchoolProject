using SchoolProyecto4.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SchoolProyecto4.Controllers
{
    public class UsuarioController : Controller
    {
        // GET: Usuario
        SchoolProjectEntities conexion = new SchoolProjectEntities();
        public ActionResult Index()
        {

            var lista = conexion.Usuario.ToList();
            return View(lista);
        }

        public ActionResult Details(string Rut)
        {
            if (Rut == null)
            {
                return HttpNotFound();
            }
            UsuarioContext Usuario = conexion.Usuario.Find(Rut);

            if (Usuario == null)
            {
                return HttpNotFound();
            }
            return View(Usuario);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create([Bind(Include = "Rut,NombreTrabajador,IdCargo")] UsuarioContext Usuario)
        {
            if (!ModelState.IsValid)
            {
                conexion.Usuario.Add(Usuario);
                conexion.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(Usuario);
        }

        public ActionResult Edit(string Rut)
        {
            if (Rut == null)
            {
                return HttpNotFound();
            }
            UsuarioContext Usuario = conexion.Usuario.Find(Rut);

            if (Usuario == null)
            {
                return HttpNotFound();
            }
            return View(Usuario);
        }

        public ActionResult Edit([Bind(Include = "Rut,NombreTrabajador,IdCargo")] UsuarioContext Usuario)
        {
            if (ModelState.IsValid)
            {
                conexion.Entry(Usuario).State = EntityState.Modified;
                conexion.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(Usuario);
        }

        public ActionResult Delete(string Rut)
        {
            if (Rut == null)
            {
                return HttpNotFound();
            }
            UsuarioContext Usuario = conexion.Usuario.Find(Rut);

            if (Usuario == null)
            {
                return HttpNotFound();
            }
            return View(Usuario);
        }

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(string Rut)
        {
            UsuarioContext Usuario = conexion.Usuario.Find(Rut);
            conexion.Usuario.Remove(Usuario);
            conexion.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}