using System;
using AutoMapper;
using TicTacToeApi.Dtos;
using TicTacToeApi.Models;

namespace TicTacToeApi
{
    public class MapProfile : Profile
    {
        public MapProfile()
        {
            CreateMap<Game, GameDto>()
                .ForMember(dst => dst.Duration, opt => opt.MapFrom(src => src.Duration.TotalSeconds));
        }
    }
}

