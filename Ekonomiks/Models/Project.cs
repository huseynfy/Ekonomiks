using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ekonomiks.Models
{
    public class Project
    {
        public int Id { get; set; }
        public string Header { get; set; }
        public string Info { get; set; }
        public string Importance { get; set; }
        public string Goal { get; set; }
        public string Image { get; set; }
        public DateTime DateTime { get; set; }
    }
}
