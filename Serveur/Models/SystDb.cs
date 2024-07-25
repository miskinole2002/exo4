using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Serveur.Models
{
    public class SystDb:DbContext
    {
        public DbSet<Securite> Security {get;set;}
    }
}