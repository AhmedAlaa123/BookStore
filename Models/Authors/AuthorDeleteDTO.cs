using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace BookStore.Models.Authors
{
    public class AuthorDeleteDTO
    {
        [Required]
        [NotNull]
        public int Id { get; set; }
    }
}
