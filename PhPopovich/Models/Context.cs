using System.Linq;
using EnglishApp.Models.Pages;
using Microsoft.EntityFrameworkCore;

namespace EnglishApp.Models
{
    public class Context : DbContext
    {
        public Context(DbContextOptions options) : base(options)
        {
        }

        public DbSet<FileModel> Files { get; set; }

        public DbSet<AdminModel> AdminModels { get; set; }

        public DbSet<ImageModel> Images { get; set; }

        public DbSet<CmsModel> CmsModels { get; set; }

        public DbSet<MainPageModel> MainPageModels { get; set; }
      
        public DbSet<UserModel> Users { get; set; }

        public DbSet<WordModel> Words { get; set; }

        public IQueryable<T> GetDbSet<T>(T type)
            where T : class
        {
            return Set<T>()?.AsQueryable();
        }
    }
}
