﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeFirstApp.Models
{
    public class CustomerModel
    {
        public int id { get; set; }
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }
        public List<Customer_ProducteModel> Customer_ProducteModels { get; set; }
    }
}
