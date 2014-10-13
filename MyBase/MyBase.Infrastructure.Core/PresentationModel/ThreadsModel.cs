using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyBase.Domain.Core.Entities;

namespace MyBase.Infrastructure.Core.PresentationModel
{
    public class ThreadsModel
    {
        public IEnumerable<Thread> Threads{get;set;}
    }
}
