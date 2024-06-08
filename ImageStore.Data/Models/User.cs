using System.ComponentModel.DataAnnotations;
using ImageStore.Data.Constants;

namespace ImageStore.Data.Models
{
    public class User
    {
        public int Id { get; set; }

        [MaxLength(DbAttributesConstants.MaxLength64)]
        public string? UserName { get; set; }

        [MaxLength(DbAttributesConstants.MaxLength64)]
        public string Password { get; set; } = null!;

        public required DateTime CreatedAt { get; set; }
    }
}
