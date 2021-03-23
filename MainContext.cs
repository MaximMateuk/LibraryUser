using System.Data.Entity;

namespace LibraryUser
{
    class MainContext : DbContext
    {
        public MainContext()
           : base("DbConnection")
        { }

        public DbSet<Book> Books { get; set; }
    }
}
