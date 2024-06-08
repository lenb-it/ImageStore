using ImageStore.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace ImageStore.Data.ContextHelpers
{
    internal static class ImageContextHelper
    {
        internal static void ImageModelCreating(this ModelBuilder builder)
        {
            builder.Entity<Image>(i =>
            {
                i.HasKey(x => x.Id);
                i.HasIndex(x => x.FileName).IsUnique();
            });
        }
    }
}
