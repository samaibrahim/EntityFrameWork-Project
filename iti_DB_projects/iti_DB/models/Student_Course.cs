using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iti_DB.models
{
    public class Student_Course
    {
        [ForeignKey("Course")]
        public int Crs_Id { get; set; }

        [ForeignKey("Student")]
        public int St_Id { get;set; }
        public int? Grade { get; set; }
        public virtual Student Student { get; set; }
        public virtual Course Course { get; set; }

    }
}
