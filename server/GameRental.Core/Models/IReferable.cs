using System;

namespace GameRental.Core.Models
{
    public interface IReferable
    {
        Guid Ref { get; set; }
    }
}