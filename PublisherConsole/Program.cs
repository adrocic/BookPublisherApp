using PublisherData;
using PublisherDomain;
using Microsoft.EntityFrameworkCore;
using System;

PublisherAppContext dbContext = new PublisherAppContext(); //existing database

// NewAuthorAndBook();
//void NewAuthorAndBook()
//{
//    var author = new Author { FirstName = "Deirdre", LastName = "Sinnott" };

//    author.Books.Add(new Book
//    {
//        Title = "The Third Mrs. Galway",
//        PublishDate = new DateTime(2021, 1, 1)
//    }
//    );

//    dbContext.Authors.Add(author);
//    dbContext.SaveChanges();
//}


// Cicular reference graph retrieval of Artists Including Covers, looping through artists, then looping through the covers belonging -
// to those artists, then grabbing artists again belonging to those covers. Artists -> Covers -> Artists
RetrieveAllArtistsWithTheirCovers();
void RetrieveAllArtistsWithTheirCovers()
{
    var artistsWithCovers = dbContext.Artists.Include(a => a.Covers).ToList();
    foreach (var artist in artistsWithCovers)
    {
        Console.WriteLine($"{artist.FirstName} {artist.LastName}, Designs to work on:");
        if (artist.Covers.Count() == 0)
        {
            Console.WriteLine(" No covers");
        }
        else
        {
            foreach (var c in artist.Covers)
            {
                string collaborators = "";
                foreach (var ca in c.Artists.Where(ca => ca.ArtistId != artist.ArtistId))
                {
                    collaborators += $"{ca.FirstName} {ca.LastName}";
                }
                if (collaborators.Length > 0)
                {
                    collaborators = $"(with {collaborators})";
                }
                Console.WriteLine($" *{c.DesignIdeas} {collaborators}");
            }
        }
    }
}

// Just connects up a few artists and covers
//ConnectAFewArtistsAndCovers();
//void ConnectAFewArtistsAndCovers()
//{
//    var artist2 = dbContext.Artists.Find(2);
//    var artist3 = dbContext.Artists.Find(3);
//    var artist4 = dbContext.Artists.Find(4);
//    var cover2 = dbContext.Covers.Find(2);
//    var cover4 = dbContext.Covers.Find(3);

//    cover2.Artists.Add(artist2);
//    cover2.Artists.Add(artist3);
//    cover2.Artists.Add(artist4);
//    cover4.Artists.Add(artist4);

//    dbContext.SaveChanges();
//}

AFewQueries();
void AFewQueries()
{
    var authors = dbContext.Authors.TagWith("RobustQueryHint").ToList();
    var books = dbContext.Books.ToList();
}

Transformer();

void Transformer()
{
    // transforming our query result by the exact data we want
    var unknownType = dbContext.Authors.Select(a => new { AuthorId = a.AuthorId, Name = a.FirstName.First() + "" + a.LastName, Books = a.Books }).ToList();
    var debugview = dbContext.ChangeTracker.DebugView.ShortView;
}

FilterUsingRelatedData();

void FilterUsingRelatedData()
{
    // filtering authors, but using the authors books to filter.
    var recentAuthors = dbContext.Authors.Where(a => a.Books.Any(b => b.PublishDate.Year >= 2015)).ToList();
}

EagerLoadBooksWithAuthors();

void EagerLoadBooksWithAuthors()
{
    // retrieving all Authors with navigational query, but then also sort of looping through and -
    // - loading the books for each author and filtering
    // Include is used on DbSet
    // We can drill down further into the layers using ThenInclude - Authors(DbSet) -> drill -> Books -> drill -> Covers
    // We can split the queries with AsSpliteQuery if we need to since this drilling can have negative performance implications
    var authorsWithBook = dbContext.Authors.Include(a => a.Books.Where(b => b.PublishDate >= new DateTime(2010, 1, 1)).OrderBy(b => b.Title));
    var authorsFilteredThenWithBooks = dbContext.Authors.Where(a => a.FirstName == "Adam").Include(a => a.Books).FirstOrDefault();
}