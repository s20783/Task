using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Task1.Models
{
    public class TaskString
    {
        [Required]
        public string Text { get; set; }
    }
}
