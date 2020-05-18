using System;
using System.ComponentModel.DataAnnotations;

namespace GameRentalApi.Models
{
    public class GameModel : IReferenceable, ISoftDeletes
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }

        public int PublisherId { get; set; }
        public virtual PublisherModel Publisher { get; set; }
        
        public Guid Ref { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public DateTime? DeletedAt { get; set; }
    }
}