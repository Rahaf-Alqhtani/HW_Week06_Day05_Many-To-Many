using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeFirstApp.Models
{
    public class ProductModel
    {
        public int id { get; set; }
        public string Name { get; set; }
        public float Price { get; set; }
        public string Color { get; set; }

        public BranchModel Branch { get; set; }
        //fk
        public int Branches { get; set; }
        public List<Customer_ProducteModel> Customer_ProducteModels { get; set; }

    }
}
