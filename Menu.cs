using System;
using System.Globalization;
using System.Threading;

namespace LibraryUser
{
    class Menu : IMenu
    {
        private Service userService;
        private Repository repository;

        public Menu()
        {
            repository = new Repository();
            userService = new Service(repository);

            AddData();
        }

        public void Show()
        {
            Thread.CurrentThread.CurrentUICulture = CultureInfo.GetCultureInfo("uk-UA");
            Console.WriteLine(Resource.FirstMethod);
            foreach (var item in userService.FindBookByAuthor("C"))
            {
                Console.WriteLine(item.ToString());
            }
            Console.WriteLine(Resource.SecondMethod);
            Console.WriteLine(userService.FindBookByName("B").ToString());
            Console.WriteLine(Resource.ThirdMethod);
            foreach (var item in userService.FindBookByYear(2000))
            {
                Console.WriteLine(item.ToString());
            }

            userService.ReserveBook(repository.Users[0], "D");
            userService.UnReserveBook("D");

            using (var db = new MainContext())
            {
                db.Books.AddRange(repository.Books);
                db.SaveChanges();
            }
        }

        private void AddData()
        {
            repository.Books.Add(new Book() { Author = "A", IsReserved = false, Name = "B", Year = 2000 });
            repository.Books.Add(new Book() { Author = "C", IsReserved = false, Name = "D", Year = 2001 });
            repository.Books.Add(new Book() { Author = "E", IsReserved = false, Name = "F", Year = 2002 });
            repository.Users.Add(new User() { Name = "Name1", Surname = "S1" });
            repository.Users.Add(new User() { Name = "Name2", Surname = "S2" });
            repository.Users.Add(new User() { Name = "Name3", Surname = "S3" });
        }
    }
}
