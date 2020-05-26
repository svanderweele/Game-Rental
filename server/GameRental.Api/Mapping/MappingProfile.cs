using AutoMapper;
using GameRental.Api.Resources;
using GameRental.Core.Models;

namespace GameRental.Api.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            // Domain to Resource
            CreateMap<Game, GameResource>();
            CreateMap<Publisher, PublisherResource>();
            
            // Resource to Domain
            CreateMap<GameResource, Game>();
            CreateMap<PublisherResource, Publisher>();
        }
    }
}