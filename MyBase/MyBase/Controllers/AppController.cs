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
    public class AppController : Controller
    {
        //
        // GET: /App/

        private readonly IThreadsService _threadService;

        public AppController(IThreadsService ThreadService)
        {
            _threadService = ThreadService;
        }

        public ActionResult App()
        {
            return View();
        }
        
        
        
        public JsonResult  GetThreads()
        {
            var threadsmodel = _threadService.GetAllThreads();
            //thread objThread = new thread();
            //objThread.Header = "Testing";
            return Json(threadsmodel, JsonRequestBehavior.AllowGet);
        }

    }

    //public class thread
    //{
    //    public string Header { get; set; }
    //}
}
