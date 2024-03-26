using PublisherData;
using PublisherDomain;
using Microsoft.EntityFrameworkCore;

PubContext _context = new PubContext(); //existing database

// NewAuthorAndBook();
void NewAuthorAndBook()
{
    var author = new Author { FirstName = "Deirdre", LastName = "Sinnott" };

    author.Books.Add(new Book
    {
        Title = "The Third Mrs. Galway",
        PublishDate = new DateTime(2021, 1, 1)
    }
    );

    _context.Authors.Add(author);
    _context.SaveChanges();
}


AFewQueries();
void AFewQueries()
{
    var authors = _context.Authors.TagWith("RobustQueryHint").ToList();
    var books = _context.Books.ToList();
}

Transformer();

void Transformer()
{
    // transforming our query result by the exact data we want
    var unknownType = _context.Authors.Select(a => new { AuthorId = a.AuthorId, Name = a.FirstName.First() + "" + a.LastName, Books = a.Books }).ToList();
    var debugview = _context.ChangeTracker.DebugView.ShortView;
}

FilterUsingRelatedData();

void FilterUsingRelatedData()
{
    // filtering authors, but using the authors books to filter.
    var recentAuthors = _context.Authors.Where(a => a.Books.Any(b => b.PublishDate.Year >= 2015)).ToList();
}

EagerLoadBooksWithAuthors();

void EagerLoadBooksWithAuthors()
{
    // retrieving all Authors with navigational query, but then also sort of looping through and -
    // - loading the books for each author and filtering
    // Include is used on DbSet
    // We can drill down further into the layers using ThenInclude - Authors(DbSet) -> drill -> Books -> drill -> Covers
    // We can split the queries with AsSpliteQuery if we need to since this drilling can have negative performance implications
    var authorsWithBook = _context.Authors.Include(a => a.Books.Where(b => b.PublishDate >= new DateTime(2010, 1, 1)).OrderBy(b => b.Title));
    var authorsFilteredThenWithBooks = _context.Authors.Where(a => a.FirstName == "Adam").Include(a => a.Books).FirstOrDefault();
}