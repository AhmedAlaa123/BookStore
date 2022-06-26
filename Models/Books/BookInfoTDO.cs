using BookStore.Models.Departments;

namespace BookStore.Models.Books
{
    public class BookInfoTDO
    {
        public int Title { get; set; }

        public int Copies { get; set; }

        public string Edition { get; set; }


        public int Author_Id { get; set; }
        public DepartmentInfoTDO Department { get; set; }


    }
}
