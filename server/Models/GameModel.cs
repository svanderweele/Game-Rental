using System.ComponentModel.DataAnnotations;

namespace GameRentalApi.Models
{
    public class GameModel
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public int PublisherId { get; set; }
        public virtual PublisherModel Publisher { get; set; }
    }
}