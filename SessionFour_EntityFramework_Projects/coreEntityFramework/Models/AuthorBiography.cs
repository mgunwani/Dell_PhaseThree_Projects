using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace coreEntityFramework.Models
{
    public class AuthorBiography
    {
        // Scalar Properties
        public int AuthorBiographyId { get; set; }
        public string Biography { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string PlaceOfBirth { get; set; }
        public string Nationality { get; set; }
        [Column("CurrentCity")]
        public string City { get; set; }

        // Navigation Properties
        public int AuthorId { get; set; }
        public Author Author { get; set; }
    }
}
