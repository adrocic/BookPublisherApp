using Bogus;
using PublisherDomain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace PublisherData
{
    internal class FakeData
    {
        public static List<Author> Authors = new List<Author>();
        public static List<Book> Books = new List<Book>();

        public static void Init(int count)
        {
            /* Authors Seeding */
            Authors.Clear(); // Clear existing authors to avoid duplicate keys
            var authorId = 1; // Reset only after clearing the list
            var authorFaker = new Faker<Author>()
               .RuleFor(author => author.AuthorId, _ => authorId++)
               .RuleFor(author => author.FirstName, f => f.Name.FirstName())
               .RuleFor(author => author.LastName, f => f.Name.LastName())
               .RuleFor(author => author.LastUpdated, f => f.Date.Recent(30)); // Random date last 30 years

            var authors = authorFaker.Generate(count);
            FakeData.Authors.AddRange(authors);

            /* Books Seeding */
            Books.Clear();
            var bookId = 1;
            var bookFaker = new Faker<Book>()
                .RuleFor(b => b.BookId, _ => bookId++)
                .RuleFor(b => b.Title, f => f.Company.Bs())
                .RuleFor(b => b.PublishDate, f => f.Date.Past(10)) // Books published in the last 10 years
                .RuleFor(b => b.BasePrice, f => f.Random.Decimal(5, 100)) // Random price between 5 and 100
                .RuleFor(b => b.AuthorId, f => f.Random.Int(1, authors.Count));

            var books = bookFaker.Generate(count);
            FakeData.Books.AddRange(books);
        }
    }
}
