using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TutorialTeacherMVCTutorial.Models
{
    public class Student
    {
        public int StudentId { get; set; }
        [Display(Name = "Name")]
        [Required]
        public string StudentName { get; set; }
        [Range(5,50)]
        public int Age { get; set; }        
    }
}