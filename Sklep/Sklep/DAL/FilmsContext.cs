using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Sklep.DAL
{
    public class FilmsContext :DbContext
    {
        public DbSet<Film> Films { get; set; }


        public DbSet<Categories> Categories { get; set; }

        public FilmsContext() : base("FilmsContext")
        {

        }

    }
}