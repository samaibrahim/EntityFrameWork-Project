using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iti_DB.models
{
    public class Ins_Crs
    {

        [ForeignKey("Instructor")]
        public int Ins_Id{ get; set; }

        [ForeignKey("Course")]
        public int Crs_Id { get; set; }
        public string? Evaluation { get; set; }

        public virtual Instructor Instructor { get; set; }
        public virtual Course Course { get; set; }

    }
}
