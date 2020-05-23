using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace AspNetMVC.Models
{
    public class Clientes
    {
        public int ID { get; set; }
        public string nombre { get; set; }
        public DateTime FechaAlta { get; set; }
        public int edad { get; set; }

        public class EmpDBContext: DbContext
        {
            public EmpDBContext()
            {

            }

            public  DbSet<Clientes> Clientes { get; set; }
        }

    }
}