using AspNetMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.WebSockets;

namespace AspNetMVC.Controllers
{
    public class ClientesController : Controller
    {
        public static List<Clientes> empList = new List<Clientes>
        {
            new Clientes
                {
                    ID = 1,
                    nombre = "Duvan",
                    FechaAlta = DateTime.Parse(DateTime.Today.ToString()),
                    edad = 30
                },
                new Clientes
                {
                    ID = 2,
                    nombre = "Patricia",
                    FechaAlta = DateTime.Parse(DateTime.Today.ToString()),
                    edad = 35
                },
        };


        // GET: Clientes
        public ActionResult Index()
        {
            var Clientes = from e in empList
                           orderby e.ID
                           select e;
            return View(Clientes);
        }

        // GET: Clientes/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Clientes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Clientes/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Clientes/Edit/5
        public ActionResult Edit(int id)
        {
            List<Clientes> emplList = TodoLosClientes();
            var Clientes = empList.Single(m => m.ID == id);
            return View(Clientes);
        }

        // POST: Clientes/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                var Clientes = empList.Single(m => m.ID == id);
                if (TryUpdateModel(Clientes))
                    return RedirectToAction("Index");
                return View(Clientes);
            }
            catch
            {
                return View();
            }
        }

        // GET: Clientes/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Clientes/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        [NonAction]
        public List<Clientes> TodoLosClientes()
        {
            return new List<Clientes>
            {
                new Clientes
                {
                    ID = 1,
                    nombre = "Duvan",
                    FechaAlta = DateTime.Parse(DateTime.Today.ToString()),
                    edad = 30
                },
                new Clientes
                {
                    ID = 2,
                    nombre = "Patricia",
                    FechaAlta = DateTime.Parse(DateTime.Today.ToString()),
                    edad = 35
                }
            };
        }


    }
}
