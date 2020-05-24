using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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
    }

    public class EmpDBContext : DbContext
    {
        //DbSet<Clientes> Clientes { get; set; }

        public System.Data.Entity.DbSet<AspNetMVC.Models.Clientes> Clientes { get; set; }
    }
}