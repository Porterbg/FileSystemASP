using System;
using System;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;

namespace FileSystem.Models
{
    public class Audio
    {
        [Key]
        public int Id { get; set; }
        public string Artist { get; set; }
        public string Album { get; set; }
        [Required]
        public string Title { get; set; }
        public string Genre { get; set; }
        public int Artist { get; set; }

    }
}
