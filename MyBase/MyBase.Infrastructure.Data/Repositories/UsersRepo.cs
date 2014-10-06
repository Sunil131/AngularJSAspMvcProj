using System;
using System.Data.Entity.Core.Objects;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyBase.Domain.Interface;
using MyBase.Domain.Core.Entities;
//using MyBase.Infrastructure.Data.Model;

namespace MyBase.Infrastructure.Data.Repositories
{
    public class UsersRepo : IUserRepo
    {

        public List<UserProfile> GetAllUserName()
        {
            using (var entities = new MyBase.Infrastructure.Data.Model.MyBaseProjEntities())
            {
                return entities.UserProfiles.ToList();
            }
        }


        public UserProfile GetUserByUserId(Func<UserProfile, bool> predicate)
        {
            using (var entities = new MyBase.Infrastructure.Data.Model.MyBaseProjEntities())
            {
                return  entities.UserProfiles.Include("User").Where(predicate).SingleOrDefault();
            }
        }


        public int CreateUserDetails(User user)
        {
            using (var entities = new MyBase.Infrastructure.Data.Model.MyBaseProjEntities())
            {
                entities.Users.Add(user);
                return entities.SaveChanges();
            }
        }
    }
}
