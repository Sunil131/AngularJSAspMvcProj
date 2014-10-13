using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyBase.Domain.Interface;
using MyBase.Domain.Core.Entities;

namespace MyBase.Infrastructure.Data.Repositories
{
    public class ThreadsRepo:IThreadsRepo
    {
        public IEnumerable<Thread> GetAllThreads()
        {
            var entities = new MyBase.Infrastructure.Data.Model.MyBaseProjEntities();
            return entities.Threads.ToList();
        }
    }
}
