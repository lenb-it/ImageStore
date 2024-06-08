using ImageStore.Data.ContextHelpers;
using ImageStore.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace ImageStore.Data.Contexts
{
    public class ImageStoreContext : DbContext
    {
        public ImageStoreContext(DbContextOptions<ImageStoreContext> options) 
            : base(options) { }

        public DbSet<User> Users { get; set; }

        public DbSet<Image> Images { get; set; }

        public DbSet<UserFolder> UserFolders { get; set; }

        public DbSet<ImageFolder> ImageFolders { get; set; }

        public DbSet<ImageVisibility> ImageVisibilities { get; set; }

        public DbSet<UserFolderVisibility> UserFolderVisibilities { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ImageModelCreating();
            modelBuilder.ImageVisibilityModelCreating();
            modelBuilder.FolderVisibilityModelCreating();

            base.OnModelCreating(modelBuilder);
        }
    }
}
