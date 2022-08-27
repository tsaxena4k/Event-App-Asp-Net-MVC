using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TSEventApp.Application.Models;
using TSEventApp.Core.Entities;
using TSEventApp.Web.Models;

namespace TSEventApp.Web.Mapper
{
    public class EventProfiles:Profile
    {
            public EventProfiles()
            {
                CreateMap<EventModel, EventViewModel>().ReverseMap();
                CreateMap<SignUpModel, SignUpViewModel>().ReverseMap();
                CreateMap<LoginModel, LoginViewModel>().ReverseMap();
                CreateMap<CommentModel, CommentViewModel>().ReverseMap();
            }
    }
}
