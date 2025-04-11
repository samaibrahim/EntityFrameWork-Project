using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iti_DB.models
{
    public class Student
    {
        [Key]
        public int St_Id { get; set; }
        public string? FName { get; set; }
        public string? LName { get; set; }
        public string? St_Address { get; set; }
        public int? St_Age { get; set; }
        //self relation
        [ForeignKey("Superviser")]
        public int? St_super { get; set; }
        public  Student  Superviser { get; set; }

        public ICollection<Student> students { get; set; }=new HashSet <Student>();
        //end self relation

        [ForeignKey("Department")]
        public int? Dept_Id { get; set; }

        public Department Department { get; set; }

        public virtual ICollection<Student_Course> Student_Courses { get; set; }
        = new HashSet<Student_Course>();
    }
}
