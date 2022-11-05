using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_Logic_Layer.Models
{
    public class ToDoModel
    {
        public int? CategoryId { get; set; }
        public string Description { get; set; }
        public string Name { get; set; }
        public bool? IsDone { get; set; }
    }
}
