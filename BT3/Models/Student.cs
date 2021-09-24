using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BT3.Models
{
    public class Student
    {
        public string StudentID { get; set; }
        [Required(ErrorMessage ="Ten sinh vien khong duoc de trong")]
        [MinLength(3)]
        public string StudentName { get; set; }
        [Required]
        public string Address { get; set; }
    }
}