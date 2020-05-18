
using System;

namespace GameRentalApi.Models
{
    public interface IReferenceable
    {
        Guid Ref { get; set; }
    }
}