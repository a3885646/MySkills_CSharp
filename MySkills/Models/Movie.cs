using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MySkills.Models
{
    public class Movie
    {
        public int ID { get; set; }
        public String Title { get; set; }

        public decimal BoxOffice { get; set; }

        public String Genre { get; set; }

        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }
    }
}
