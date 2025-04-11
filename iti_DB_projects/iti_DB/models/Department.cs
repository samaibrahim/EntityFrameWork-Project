using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iti_DB.models
{
    public class Department
    {
        [Key]
        public int Dept_Id { get; set; }
        public string? Dept_Name { get; set; }
        public string? Dept_Desc { get; set; }
        public string? Dept_Location { get; set; }

        //one to one
        public int? Dept_Maneger { get; set; }
        public virtual Instructor?  Manager_ins { get; set; }
        //end one to one
        public DateTime? Maneger_Hiredate { get; set; }

        public virtual ICollection<Student> Students { get; set; } = new HashSet<Student>();
        public virtual ICollection<Instructor> Instructors { get; set; }= new HashSet<Instructor>();
    }
}
