using BookStore.Models.Departments;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookStore.Models.Books
{
    public class Book
    {
        [Key]
        public int Id { get; set; }
        [MinLength(2)]
        [MaxLength(50)]
        [Required]
        public int Title { get; set; }

        public int Copies { get; set; }
        [Required]
        public string Edition { get; set; }

        [Required]
        public int Author_Id { get; set; }

        [ForeignKey("Department")]
        [Required]
        public int Dept_Id { get; set; }

        public Department Department { get; set; }

    }
}
