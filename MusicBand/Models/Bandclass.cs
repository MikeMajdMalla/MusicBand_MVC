namespace MusicBand.Models
{
    public class Band
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string? ImageLink { get; set; }
        public List<Genre>? Genre { get; set; }
    }

    public class Genre
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Band? Band { get; set; }
        public int BandId { get; set; }
    }


}
