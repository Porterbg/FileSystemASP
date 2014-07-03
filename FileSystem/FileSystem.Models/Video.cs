using System;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;

namespace FileSystem.Models
{
    public class Video
    {
        [Key]
        public int Id { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public int Duration { get; set; }
        public int FPS { get; set; }
        public int Videobitrate { get; set; }
        public int Audiobitrate { get; set; }
        public int Audiosamplerate { get; set; }
        public int Rotate { get; set; }
        public int Audiocodec { get; set; }
        public int Videocodec { get; set; }

    }
}
