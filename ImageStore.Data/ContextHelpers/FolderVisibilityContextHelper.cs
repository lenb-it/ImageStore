using ImageStore.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace ImageStore.Data.ContextHelpers
{
    internal static class FolderVisibilityContextHelper
    {
        internal static void FolderVisibilityModelCreating(this ModelBuilder builder)
        {
            builder.Entity<UserFolderVisibility>(f =>
            {
                f.HasIndex(x => x.UserFolderId).IsUnique();
            });
        }
    }
}
