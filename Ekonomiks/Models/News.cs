using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ekonomiks.Models
{
    public class News
    {
        public int Id { get; set; }
        public string Header { get; set; }
        public string Body { get; set; }
        public string Image { get; set; }
        public DateTime DateTime { get; set; }
        public string Category { get; set; }
      
    }
}
