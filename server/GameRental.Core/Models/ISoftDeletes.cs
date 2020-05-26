using System;

namespace GameRental.Core.Models
{
    public interface ISoftDeletes
    {
        DateTime CreatedAt { get; set; }
        DateTime UpdatedAt { get; set; }
        DateTime? DeletedAt { get; set; }
    }
}