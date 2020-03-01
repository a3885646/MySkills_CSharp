using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MySkills.Models
{
    public class Movie
    {
        public int ID { get; set; }
        [StringLength(60, MinimumLength = 2), Required]
        public string Title { get; set; }

        [Range(1,100), DataType(DataType.Currency)]
        [Column(TypeName ="decimal(18,2)")]
        public decimal BoxOffice { get; set; }

        [RegularExpression(@"^[A-Z]+[a-zA-Z""'\s-]*$"), StringLength(30), Required]
        public string Genre { get; set; }

        [Display(Name ="Release Date"), DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }

        [RegularExpression(@"^[A-Z]+[a-zA-Z0-9""'\s-]*$"), Required, StringLength(10)]
        public string Rating { get; set; }
    }
}
