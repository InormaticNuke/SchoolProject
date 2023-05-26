using SchoolProyecto4.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SchoolProyecto4.Controllers
{
    public class CargoController : Controller
    {
        SchoolProjectEntities conexion = new SchoolProjectEntities();
        public ActionResult Index()
        {
            var listar = from p in conexion.Cargo select p;
            return View(listar);
        }

        public ActionResult ListarPorEnlace()
        {
            var listarPorCargo = conexion.Cargo;
            return View(listarPorCargo.ToList());
        }

        public ActionResult Usuario(int cargo)

        {

            var query = from p in conexion.Usuario where p.cargo.IdCargo == cargo select p;
            return View(query.ToList());
        }

        public ActionResult ListarUsuarioNombreCargo()
        {

            var modelo = from p in conexion.Usuario
                         join c in conexion.Cargo
                         on p.Idcargo equals c.IdCargo

                         select new UsuarioContext
                         {
                             Rut = p.Rut,
                             NombreTrabajador = p.NombreUsuario,
                             IdCargo = c.NombreCargo
                         };
            return View(modelo.ToList());
        }

        public ActionResult PruebaList()
        {
            var lista = from x in conexion.Usuario
                        select new UsuarioContext
                        {
                            Rut = x.Rut,
                            NombreTrabajador = x.NombreUsuario,
                            IdCargo = x.Idcargo.ToString()
                        };
            return View(lista);
        }
    }
}