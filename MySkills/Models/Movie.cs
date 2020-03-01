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
        public String Title { get; set; }

        [Column(TypeName ="decimal(18,2)")]
        public decimal BoxOffice { get; set; }

        public String Genre { get; set; }

        [Display(Name ="Release Date")]
        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }
    }
}
