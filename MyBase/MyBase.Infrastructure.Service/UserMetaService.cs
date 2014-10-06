using System;
using AutoMapper;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyBase.Infrastructure.Core.ServiceInterface;
using MyBase.Domain.Interface;
using MyBase.Domain.Core.Entities;
using MyBase.Infrastructure.Core.PresentationModel;

namespace MyBase.Infrastructure.Service
{
    public class UserMetaService : IUserMetaService
    {
        private readonly IUserRepo _userRepo;

        public UserMetaService(IUserRepo userRepo) 
        {
            _userRepo = userRepo;
        }
   
       public UserModel GetAllUsers()
        {

             UserModel userModel = new UserModel
             {
                 UserNames = _userRepo.GetAllUserName()
             };

             return userModel;
        }




       public UserDetailsModel FindUserProfileByUserId(string UserName)
       {
           var userDetailModel = Mapper.Map<UserProfile, UserDetailsModel>(_userRepo.GetUserByUserId(cond => cond.UserName.Equals(UserName)));
           return userDetailModel;

       }

       public UserProfile FindUserDetailsByUserId(string UserName)
       {
           return _userRepo.GetUserByUserId(cond => cond.UserName.Equals(UserName));

       }

       public int CreateUserData(UserDetailsModel userDetailsModel)
       {
           
           var user = Mapper.Map<UserDetailsModel, User>(userDetailsModel);
           //user.ID = user.UserProfile.UserId;
           user.CreatedBy = 0;
           user.CreatedOn = DateTime.Now;
           return _userRepo.CreateUserDetails(user);
       }
    }
}
