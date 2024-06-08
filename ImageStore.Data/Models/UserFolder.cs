using System.ComponentModel.DataAnnotations;
using ImageStore.Data.Constants;

namespace ImageStore.Data.Models
{
    public class UserFolder
    {
        public int Id { get; set; }

        public required int UserId { get;set; }

        [MaxLength(DbAttributesConstants.MaxLength256)]
        public string FolderName { get; set; } = null!;


        public User? User { get; set; }
    }
}
