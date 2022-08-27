using AutoMapper;
using TSEventApp.Application.Models;
using TSEventApp.Core.Entities;
using System;

namespace TSEventApp.Application.Mapper
{
    // The best implementation of AutoMapper for class libraries -> https://www.abhith.net/blog/using-automapper-in-a-net-core-class-library/
    public static class ObjectMapper
    {
        private static readonly Lazy<IMapper> Lazy = new Lazy<IMapper>(() =>
        {
            var config = new MapperConfiguration(cfg =>
            {
                // This line ensures that internal properties are also mapped over.
                cfg.ShouldMapProperty = p => p.GetMethod.IsPublic || p.GetMethod.IsAssembly;
                cfg.AddProfile<AspnetRunDtoMapper>();
            });
            var mapper = config.CreateMapper();
            return mapper;
        });
        public static IMapper Mapper => Lazy.Value;
    }

    public class AspnetRunDtoMapper : Profile
    {
        public AspnetRunDtoMapper()
        {
            //CreateMap<Event, EventModel>()
            //    .ForMember(dest => dest.ProductName, opt => opt.MapFrom(src => src.ProductName)).ReverseMap();

            CreateMap<Event, EventModel>().ForMember(dst=>dst.Organiser,opt=>opt.MapFrom(src=>src.Organiser)).ReverseMap();
            CreateMap<SignUp, SignUpModel>().ReverseMap();
            CreateMap<Login, LoginModel>().ReverseMap();
            CreateMap<Comment, CommentModel>().ReverseMap();
        }
    }
}
