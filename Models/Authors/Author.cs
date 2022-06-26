using BookStore.Models.Books;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookStore.Models.Authors
{
    public class Author
    {
        public int Id { get; set; }
        [Required]
        [MinLength(2)]
        [MaxLength(50)]
        public string Name { get; set; }
        public string Address { get; set; }
        public DateOnly BirthDate { get; set; }
        public ICollection<Book> Books { get; set; } 

    }
}
