using SchoolProyecto2.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SchoolProyecto2.Controllers
{
    public class ColegioController : Controller
    {
        SchoolProjectEntities conexion = new SchoolProjectEntities();

        public ActionResult Index()
        {
            // la vista "Index" nos retornara la lista de los cargos de la base de datos
            var listar = from p in conexion.Colegios select p;
            return View(listar);
        }

        public ActionResult ListarPorEnlace()
        {
            // la vista "ListarPorEnlace" nos permitira acceder a los cargos por enlace o link
            var listarPorCargo = conexion.Colegios;
            return View(listarPorCargo.ToList());
        }

        public ActionResult Usuario(int cargo)

        {
            //CONSULTA LINQ -- Significado:
            //la variable x dentro de la tabla usuario. donde el cargo va a ser igual al cargo que se envia
            //si se encuentra la query retornara la lista.
            var query = from p in conexion.Colegios where p.cargo.IdCargo == cargo select p;
            return View(query.ToList());
        }

        public ActionResult ListarUsuarioNombreCargo()
        {
            //LINQ con JOIN - Se conecta por medio del id de cargo de usuario y el id de cargo que tiene la tabla cargo

            var modelo = from p in conexion.Usuarios
                         join c in conexion.Colegios
                         on p.Idcargo equals c.IdCargo
                         //si el join se cumple, se crea un nuevo usuario que va a tener su rut y va a recibir
                         //un rut que venga de la base de datos, con su nombre y cargo
                         select new UsuarioViewModel
                         {
                             rut = p.Rut,
                             nombre = p.NombreUsuario,
                             cargo = c.NombreCargo
                         };
            return View(modelo.ToList());
        }

        public ActionResult PruebaList()
        {
            var lista = from x in conexion.Colegios
                        select new UsuarioViewModel
                        {
                            rut = x.Rut,
                            nombre = x.NombreUsuario,
                            cargo = x.Idcargo.ToString()
                        };
            return View(lista);
        }


    }
}