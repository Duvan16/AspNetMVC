using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AspNetMVC.Controllers
{
    public class ProveedoresController : Controller
    {
        // GET: Proveedores
        public string  TodosLosProveedores()
        {
            return @"<ul>
                    <li>Alcampo</li>
                    <li>Carrefour</li>
                    <li>Mercadona</li>
                    <li>Gadis</li>
                    ";
        }
    }
}