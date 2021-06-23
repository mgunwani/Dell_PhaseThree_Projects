using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EntityFrameworkCoreGuideProject.Models
{
    [Table("StudentMaster", Schema = "Academic")]
    public class Student
    {
        [Column(Order = 0)]
        [Key]
        public int StudentKey { get; set; }
        [Column("Name", Order = 1)]
        [MaxLength(10)]
        [Required(ErrorMessage = "Please Enter Student Name")]
        public string StudentName { get; set; }
        [Column("DoB", TypeName = "DateTime2", Order = 3)]
        [Required(ErrorMessage = "Please Choose Date of Birth")]
        public DateTime DateOfBirth {get;set;}
        [Required(ErrorMessage = "Please Enter Student Age")]
        [Column(Order = 2)]
        public int StudentAge { get; set; }
        [Column(Order = 4)]
        [Required(ErrorMessage = "Please Enter City")]
        public string CurrentCity { get; set; }
    }
}
