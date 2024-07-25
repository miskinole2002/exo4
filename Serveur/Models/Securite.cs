using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Serveur.Models
{
    public class Securite
    {
        [Key]
        public int Id { get; set; }
        public int Status { get; set; }

        public String Z1 { get; set; }
        public String Z2 { get; set; }
        public String Z3 { get; set; }
        public String Z4 { get; set; }
     
        

    }
}