using System;

namespace GameRentalApi.Models
{
    public interface ISoftDeletes
    {
        DateTime CreatedAt { get; set; }
        DateTime UpdatedAt { get; set; }
        DateTime? DeletedAt { get; set; }
    }
}