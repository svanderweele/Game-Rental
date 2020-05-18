using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace GameRentalApi.Models
{
    public class PublisherModel: IReferenceable
    {
        [Key] public int Id { get; set; }
        public string Name { get; set; }

        public virtual List<GameModel> Games { get; set; }
        public Guid Ref { get; set;}
    }
}