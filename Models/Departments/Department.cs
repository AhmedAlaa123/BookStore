using BookStore.Models.Books;
using System.ComponentModel.DataAnnotations;

namespace BookStore.Models.Departments
{
    public class Department
    {
        [Key()]
  
        public int Id { get; set; }
        [Required]
        [MinLength(5)]
        [MaxLength(40)]
        public string Name { get; set; }

        [MinLength(4)]
   
        public string? Code { get; set; }

        public List<Book> Books { get; set; }

    }
}
