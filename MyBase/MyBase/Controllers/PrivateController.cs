using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MyBase.Infrastructure.Service;
using MyBase.Infrastructure.Data.Model;
using MyBase.Infrastructure.Core.ServiceInterface;
using MyBase.Infrastructure.Core.PresentationModel;
using MyBase.Infrastructure.DependencyResolution;
using MyBase.Domain.Core.Entities;
using MyBase.Domain.Core;


namespace MyBase.Controllers
{
    public class PrivateController : Controller
    {

        private readonly IUserMetaService _UserMetaService;


        public PrivateController(IUserMetaService _userMetaService)
        {
            _UserMetaService = _userMetaService;
        }


        //
        // GET: /Private/

        public ActionResult UserDetails(string UserName)
        {
            var userDetailModel = _UserMetaService.FindUserDetailsByUserId(UserName);
            UserDetailsModel model = new UserDetailsModel()
            {
                First = (userDetailModel.User!=null)?userDetailModel.User.First:String.Empty,
                Last = (userDetailModel.User!=null)?userDetailModel.User.Last:String.Empty,
                Middle = (userDetailModel.User!=null)?userDetailModel.User.Middle:String.Empty,
                Mobile = (userDetailModel.User!=null)?userDetailModel.User.Mobile:String.Empty,
                Phone = (userDetailModel.User!=null)?userDetailModel.User.Phone:String.Empty,
                ID = userDetailModel.UserId,
                UserId = userDetailModel.UserId,
                UserName = userDetailModel.UserName,
                DateOfBirth = (userDetailModel.User!=null)?userDetailModel.User.DateofBirth:DateTime.Now
            };

            return View(model);
        }

        //
        // POST: /Private/
        [HttpPost]
        public ActionResult UserDetails(UserDetailsModel userDetailsModel, string UserId)
        {
            userDetailsModel.UserId =Convert.ToInt32(UserId);
            userDetailsModel.ID = Convert.ToInt32(UserId);
            _UserMetaService.CreateUserData(userDetailsModel);
            return View ();;
        }

        public ActionResult ShowUserDetails(string UserName, string UserId)
        {
            var userDetailModel = _UserMetaService.FindUserDetailsByUserId(UserName);
            UserDetailsModel model = new UserDetailsModel()
            {
                First = (userDetailModel.User != null) ? userDetailModel.User.First : String.Empty,
                Last = (userDetailModel.User != null) ? userDetailModel.User.Last : String.Empty,
                Middle = (userDetailModel.User != null) ? userDetailModel.User.Middle : String.Empty,
                Mobile = (userDetailModel.User != null) ? userDetailModel.User.Mobile : String.Empty,
                Phone = (userDetailModel.User != null) ? userDetailModel.User.Phone : String.Empty,
                ID = userDetailModel.UserId,
                UserId = userDetailModel.UserId,
                UserName = userDetailModel.UserName,
                DateOfBirth = (userDetailModel.User != null) ? userDetailModel.User.DateofBirth : DateTime.Now
            };

            return View(model);
        }
    }
}
