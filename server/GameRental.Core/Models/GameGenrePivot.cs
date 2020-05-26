namespace GameRental.Core.Models
{
    public class GameGenrePivot
    {
        public int GameId { get; set; }
        public Game Game { get; set; }
        public int GenreId { get; set; }
        public GameGenre Genre { get; set; }
    }
}