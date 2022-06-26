using System.ComponentModel.DataAnnotations;

namespace BookStore.Models.Books
{
    public class BookCreateTDO
    {
        [MinLength(2,ErrorMessage ="*Minimu Length Of Title is 2 charcter")]
        [MaxLength(50, ErrorMessage = "*Maximum Length Of Title is 50 charcter")]
        [Required(ErrorMessage ="*Book Title Is Required")]
        public int Title { get; set; }
        public int Copies { get; set; }
        [Required(ErrorMessage = "*Book Edition Is Required")]
        public string Edition { get; set; }
        [Required(ErrorMessage = "*Author Name Is Required")]

        public int Author_Id { get; set; }
        [Required(ErrorMessage = "*Department Name Is Required")]
        public int Dept_Id { get; set; }
    }
}
