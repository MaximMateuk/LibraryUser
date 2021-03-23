using System;
using System.Collections.Generic;
using System.Linq;
using NLog;

namespace LibraryUser
{
    class Service
    {
        private Repository repository;
        private static Logger logger = LogManager.GetCurrentClassLogger();

        public Service(Repository repository)
        {
            this.repository = repository;
        }

        public List<Book> FindBookByAuthor(string author)
        {
            return repository.Books.Where(x => x.Author == author).ToList();
        }

        public Book FindBookByName(string name)
        {
            return repository.Books.FirstOrDefault(x => x.Name == name);
        }

        public List<Book> FindBookByYear(int year)
        {
            return repository.Books.Where(x => x.Year == year).ToList();
        }

        public void ReserveBook(User user , string bookname)
        {
            try
            {
                user.Books.Add(repository.Books.First(x => x.Name == "R"));
                repository.Books.FirstOrDefault(x => x.Name == bookname).IsReserved = true;
            }
            catch(Exception c)
            {
                logger.Error($"Ошибка резерва книги! {c.Message}");
            }
        }

        public void UnReserveBook(string bookname)
        {
            repository.Books.FirstOrDefault(x => x.Name == bookname).IsReserved = false;
        }
    }
}
