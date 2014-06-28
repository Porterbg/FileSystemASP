using System;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;

namespace FileSystem.Models
{
    public class FileSystem
    {
        [Key]
        public string Id { get; set; }
        [Required]
        public bool IsMine { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string ParentFolderId { get; set; }
        [Required]
        public bool Thumb { get; set; }
        [Required]
        public bool CanRead { get; set; }
        [Required]
        public bool CanModify { get; set; }
        [Required]
        public bool CanDelete { get; set; }
        [Required]
        public bool CanCreate { get; set; }
        [Required]
        public bool IsShared { get; set; }
        [Required]
        public string Path { get; set; }
        [Required]
        public bool IsFolder { get; set; }
        public string FolderId { get; set; }
        public string FileId { get; set; }
        public string DeletedFileId { get; set; }
        [Required]
        public DateTime Created { get; set; }
        [Required]
        public DateTime Modified { get; set; }
        public string Icon { get; set; }
        public Categories Category { get; set; }
        public long Size { get; set; }
        public string ContentType { get; set; }
        public string Hash { get; set; }
        [Required]
        public bool IsDeleted { get; set; }

        public virtual Image Image { get; set; }
        public virtual Video Video { get; set; }
        public virtual Audio Audio { get; set; }

        public virtual ICollection<FileSystem> Contents { get; set; }

        public FileSystem()
        {
            this.Contents = new HashSet<FileSystem>();
        }

    }
}
