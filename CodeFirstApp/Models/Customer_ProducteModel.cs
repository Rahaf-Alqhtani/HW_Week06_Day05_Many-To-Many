using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Linq;

namespace CodeFirstApp.Models
{
    public class Customer_ProducteModel 
    {
        public int Customer_id { get; set; }
        public CustomerModel CustomerModel { get; set; }

        public int prouduct_id { get; set; }   
        public ProductModel productModel { get; set; }

    }
}
