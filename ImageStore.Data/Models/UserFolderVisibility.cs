using ImageStore.Data.Enums;

namespace ImageStore.Data.Models
{
    public class UserFolderVisibility
    {
        public int Id { get; set; }

        public required int UserFolderId { get; set; }

        public required Visibility Visibility { get; set; }

        public required DateTime CreatedAt { get; set; }

        public required DateTime DeleteAt { get; set; }


        public UserFolder UserFolder { get; set; }
    }
}
