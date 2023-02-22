using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Mission6.Models
{
    public class Category
    {
        //This is making a new table and makign a primary key field to be linked to the other table.
        [Key]
        [Required]
        public int CategoryID { get; set; }

        public string CategoryName { get; set; }
    }
}
