using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace GameRentalApi.Models
{
    public class PublisherModel
    {
        [Key] public int Id { get; set; }
        public string Name { get; set; }

        public virtual List<GameModel> Games { get; set; }
    }
}