using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyBase.Domain.Core.Entities;
using MyBase.Infrastructure.Core.PresentationModel;
using AutoMapper;

namespace MyBase.Infrastructure.DependencyResolution
{
    public class ObjectMapping
    {
        public static void CreateMap()
        {
            Mapper.CreateMap<UserDetailsModel, User>();
            Mapper.CreateMap<User, UserDetailsModel>();

            Mapper.CreateMap<UserProfile, UserDetailsModel>();
        }
    }
}
