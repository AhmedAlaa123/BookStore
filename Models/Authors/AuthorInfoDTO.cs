using BookStore.Models.Books;
using System.ComponentModel.DataAnnotations;

namespace BookStore.Models.Authors
{
    public class AuthorInfoDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public DateOnly BirthDate { get; set; }
        public ICollection<Book> Books { get; set; }
    }
}
