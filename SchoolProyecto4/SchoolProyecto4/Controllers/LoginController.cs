using SchoolProyecto4.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SchoolProyecto4.Controllers
{
    public class LoginController : Controller
    {
        SchoolProjectEntities conexion = new SchoolProjectEntities();
        public ActionResult Index()
        {
            return View();
        }

        //Vista Validar
        public ActionResult Validar()
        {
            return View();
        }


        //Envio de Formulario Validar
        [HttpPost]
        public ActionResult Validate(string rut, string pass)
        {
            Models.Login us = conexion.Login.FirstOrDefault(u => u.Rut == rut & u.Clave == pass);

            if (us != null)
            {
                return RedirectToAction("ListarPorEnlace", "Cargo");
            }
            else
            {
                return RedirectToAction("Error", "Login");
            }
        }

        public ActionResult Error()
        {
            ViewBag.Error = "Usuario No Encontrado";
            return View();
        }
    }
}