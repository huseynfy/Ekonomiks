using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Ekonomiks.Models
{
    public class Message
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required,DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [Required]
        public string Post { get; set; }
        public DateTime Date { get; set; }
    }
}
