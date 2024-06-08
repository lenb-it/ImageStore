using ImageStore.Data.Enums;

namespace ImageStore.Data.Models
{
    public class ImageVisibility
    {
        public int Id { get; set; }

        public required int ImageId { get; set; }

        public required Visibility Visibility { get; set; }

        public required DateTime CreatedAt { get; set; }

        public required DateTime DeleteAt { get; set; }


        public Image Image { get; set; }
    }
}
