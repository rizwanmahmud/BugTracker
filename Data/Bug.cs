using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class Bug
    {
        public string Title { get; set; } = string.Empty; 

        public string State { get; set; } = string.Empty;

        public string Description { get; set; } = string.Empty;

        public DateTime Opened { get; set; } = DateTime.Now;

        public Person AssignedTo { get; set; }
    }
}
