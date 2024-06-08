using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using ImageStore.Data.Constants;

namespace ImageStore.Data.Models
{
    public class Image
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public required Guid FileName { get; set; }

        [MaxLength(DbAttributesConstants.MaxLength16)]
        public string FileExtension { get; set; } = null!;

        [MaxLength(DbAttributesConstants.MaxLength256)]
        public string OriginalFileName { get; set; } = null!;
    }
}
