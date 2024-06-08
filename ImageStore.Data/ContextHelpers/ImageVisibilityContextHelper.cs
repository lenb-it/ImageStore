using ImageStore.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace ImageStore.Data.ContextHelpers
{
    internal static class ImageVisibilityContextHelper
    {
        internal static void ImageVisibilityModelCreating(this ModelBuilder builder)
        {
            builder.Entity<ImageVisibility>(i =>
            {
                i.HasIndex(x => x.ImageId).IsUnique();
            });
        }
    }
}
