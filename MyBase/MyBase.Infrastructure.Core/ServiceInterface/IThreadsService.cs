using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyBase.Domain.Core.Entities;
using MyBase.Infrastructure.Core.PresentationModel;

namespace MyBase.Infrastructure.Core.ServiceInterface
{
    public interface IThreadsService
    {
        ThreadsModel GetAllThreads();
    }
}
