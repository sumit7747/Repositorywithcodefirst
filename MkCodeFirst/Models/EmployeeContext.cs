using MkCodeFirst.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MkCodeFirst.Models
{
    public class EmployeeContext:DbContext
    {
        public EmployeeContext() : base("myconnection")
        {
        }

        public DbSet<Emloyee> Employees { get; set; }
    }
}