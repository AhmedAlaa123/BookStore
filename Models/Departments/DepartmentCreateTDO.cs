using System.ComponentModel.DataAnnotations;

namespace BookStore.Models.Departments
{
    public class DepartmentCreateTDO
    {
        [Required(ErrorMessage ="*Department Name Is Required")]
        [MinLength(5,ErrorMessage ="*Minmum Length is 5 charcter")]
        [MaxLength(40,ErrorMessage = "*Maximum Length is 40 charcter")]
        public string Name { get; set; }

      
        [MinLength(4, ErrorMessage = "*Minmum Length is 4 charcter")]
        public string Code { get; set; }
    }
}
