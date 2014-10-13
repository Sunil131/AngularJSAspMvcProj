using System;
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
    public class ThreadsService : IThreadsService
    {
        private readonly IThreadsRepo _threadRepo;

        public ThreadsService(IThreadsRepo _ThreadRepo)
        {
            _threadRepo = _ThreadRepo;
        }

        public ThreadsModel GetAllThreads()
        {
            var threadModel = new ThreadsModel()
            {
                Threads = _threadRepo.GetAllThreads()
            };
            return threadModel;
        }
    }
}
