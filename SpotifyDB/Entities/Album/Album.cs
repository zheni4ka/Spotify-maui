using SpotifyDB.Interfaces;

namespace SpotifyDB
{
    public class Album : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime ReleaseDate { get; set; }
        public Genre Genre { get; set; }
        public int GenreId {  get; set; }
        public double Rating { get; set; }
        public int CountofListening { get; set; }
        public Artist Artist { get; set; }
    }
}
