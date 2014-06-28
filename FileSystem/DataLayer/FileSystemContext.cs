using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FileSystem.Models;

namespace DataLayer
{
    public class FileSystemContext : DbContext
    {
        public FileSystemContext()
            : base("FileSystemDb")
        {
        }

        public DbSet<FileSystem.Models.FileSystem> FileSystems { get; set; }
        public DbSet<Audio> Audios { get; set; }
        public DbSet<Video> Videos { get; set; }
        public DbSet<Image> Images { get; set; }

    }
}
