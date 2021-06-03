using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace CodeFirstApp.Models
{
    public class BranchModel


         [Key]
    public int ID { get; set; }
        [Required]
        public string Address{ get; set; }
        [Required]
        public string Name { get; set; }
        [MaxLength(20)]
        public string Area { get; set; }

        public List<ProductModel> products { get; set; }



    }
}
