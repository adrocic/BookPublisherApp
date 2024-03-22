﻿namespace PublisherDomain
{
    public class Author
    {
        public Author()
        {
            Books = new List<Book>();
        }
        public int AuthorId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime LastUpdated { get; set; }
        public List<Book> Books { get; set; }
    }
}
