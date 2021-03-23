using System.Collections.Generic;

namespace LibraryUser
{
    class Repository
    {
        public List<Book> Books { get; set; }
        public List<User> Users { get; set; }

        public Repository()
        {
            Books = new List<Book>();
            Users = new List<User>();
        }
    }
}
