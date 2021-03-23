using System;

namespace LibraryUser
{
    class Program
    {
        static void Main(string[] args)
        {
            IMenu menu = new Menu();
            menu.Show();
            Console.ReadKey();
        }
    }
}
