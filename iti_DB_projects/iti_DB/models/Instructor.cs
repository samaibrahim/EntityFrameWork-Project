using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iti_DB.models
{
    public class Instructor
    {
        [Key]
        public int Ins_Id { get; set; }
        public string? Ins_Name { get; set; }
        public string? Ins_Degree { get; set; }
        public int? Salary { get; set; }

        [ForeignKey("Department")]
        public int? Dept_id { get; set; }
        //one to one
        public virtual Department? Manager_ins { get; set; }
        //end one to one
        public Department Department { get; set; }
        public virtual ICollection<Ins_Crs> Ins_Courses { get; set; }
        = new HashSet<Ins_Crs>();

    }
}
