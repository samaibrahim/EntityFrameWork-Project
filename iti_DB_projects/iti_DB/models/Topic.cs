using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iti_DB.models
{
    public class Topic
    {
        [Key]
        public int Top_Id { get; set; }
        public string? Name { get; set; }

        public virtual ICollection<Course> Courses { get; set; }
       = new HashSet<Course>();
    }
}
