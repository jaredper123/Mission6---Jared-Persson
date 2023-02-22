using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Mission6.Models
{
    //Here, we work with the models in terms of making them required or have other parameters as well.
    public class Movie
    {

        public bool Edited { get; set; }
        public string LentTo { get; set; }

        [MaxLength(25)]
        public string Notes { get; set; }

        //Error validation
        [Key]
        [Required]
        public int movieID { get; set; }


        [Required(ErrorMessage = "Please input a title.")]
        public string Title { get; set; }


        [Required(ErrorMessage = "Please input a year.")]
        public int Year { get; set; }


        [Required(ErrorMessage = "Please input a director's name.")]
        public string Director { get; set; }


        [Required(ErrorMessage = "Please select a rating.")]
        public string Rating { get; set; }


        [Required(ErrorMessage = "Please choose a category.")]
        //foreign key
        public int CategoryID { get; set; }
        public Category Category { get; set; }
    }
}
