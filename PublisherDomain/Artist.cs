namespace PublisherDomain
{
    public class Artist
    {
        public Artist()
        {
            // In this method we are just initializing the Artists so that we can avoid null checks elsewhere in code
            Covers = new List<Cover>();
        }
        public int ArtistId { get; set; }
        public string FirstName { get; set;}
        public string LastName { get; set;}
        public List<Cover> Covers { get; set; }
    }
}
