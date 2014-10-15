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

        public IEnumerable<ThreadDetailModel> GetAllThreads()
        {
            var thread = _threadRepo.GetAllThreads();
            IEnumerable<ThreadDetailModel> threadDetails=
                AutoMapper.Mapper.Map <IEnumerable<Thread>, IEnumerable<ThreadDetailModel>>(_threadRepo.GetAllThreads());

            return threadDetails;
        }


        public bool AddNewThread(ThreadDetailModel newThread)
        {
            throw new NotImplementedException();
        }
    }
}
