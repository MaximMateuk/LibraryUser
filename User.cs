using System.Collections.Generic;

namespace LibraryUser
{
    class User
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public List<Book> Books { get; set; }

        public User()
        {
            Books = new List<Book>();
        }
    }
}
