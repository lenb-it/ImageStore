namespace ImageStore.Data.Models
{
    public class ImageFolder
    {
        public int Id { get; set; }

        public int UserFolderId { get; set; }

        public int ImageId { get; set; }


        public UserFolder UserFolder { get; set; }

        public Image Image { get; set; }
    }
}
