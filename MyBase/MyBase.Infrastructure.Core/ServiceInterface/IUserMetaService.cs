using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyBase.Domain.Core.Entities;
using MyBase.Infrastructure.Core.PresentationModel;

namespace MyBase.Infrastructure.Core.ServiceInterface
{
    public interface IUserMetaService
    {
        UserModel GetAllUsers();
        UserDetailsModel FindUserProfileByUserId(string UserName);
        UserProfile FindUserDetailsByUserId(string UserName);               
        int CreateUserData(UserDetailsModel userDetailsModel);
    }
}
