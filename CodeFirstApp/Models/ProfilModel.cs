using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeFirstApp.Models
{
    public class ProfilModel
    {
        public int Id { get; set; }
        public string Image { get; set; }
        public bool Active { get; set; }
        //navigations propeties
        public CustomerModel Customer { get; set; }
        //fk
        public int id { get; set; } 

    }
}
