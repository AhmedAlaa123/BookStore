using BookStore.Models.Books;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace BookStore.Models.Authors
{
    public class AuthorUpdateDTO
    {
        [Required]
        [NotNull]
        public int Id { get; set; }
        [Required]
        [MinLength(2)]
        [MaxLength(50)]
        public string Name { get; set; }
        [MinLength(5)]
        [MaxLength(100)]
        public string Address { get; set; }
        [DataType(DataType.Date)]
        public DateOnly BirthDate { get; set; }
        public ICollection<Book> Books { get; set; }
    }
}
