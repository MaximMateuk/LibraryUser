namespace LibraryUser
{
    class Book
    {
        public int Id { get; set; }
        public string Author { get; set; }
        public bool IsReserved { get; set; }
        public string Name { get; set; }
        public int Year { get; set; }

        public Book(string author, bool isReserved, string name, int year)
        {
            Author = author;
            IsReserved = isReserved;
            Name = name;
            Year = year;
        }

        public Book()
        {
        }

        public override string ToString()
        {
            return $"{Name} {Year} {Author} {Year}";
        }
    }
}
