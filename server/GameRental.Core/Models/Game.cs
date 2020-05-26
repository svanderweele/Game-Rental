namespace GameRental.Core.Models
{
    public class Game
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public int PublisherId {get; set;}
        public Publisher Publisher {get; set;}
    }
}