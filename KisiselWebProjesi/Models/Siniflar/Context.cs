using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace KisiselWebProjesi.Models.Siniflar
{
    public class Context:DbContext
    {
        public DbSet<Admin> Admins { get; set; }
        public DbSet <Anasayfa> Anasayfas { get; set; }
        public DbSet <İkonlar> İkonlars { get; set; }


    }
}