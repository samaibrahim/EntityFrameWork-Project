using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iti_DB.models
{
    public class Course
    {
        [Key]
        public int Crs_Id { get; set; }
        public string? Crs_Name { get; set; }
        public int? Duration { get; set; }

        [ForeignKey("Topic")]
        public int? Top_Id { get; set; }
        public Topic Topic { get; set; }

        public virtual ICollection<Student_Course> Student_Courses { get; set; }
        =new HashSet<Student_Course>();

        public virtual ICollection<Ins_Crs> Ins_Courses { get; set; }
        = new HashSet<Ins_Crs>();

        
    }
}
