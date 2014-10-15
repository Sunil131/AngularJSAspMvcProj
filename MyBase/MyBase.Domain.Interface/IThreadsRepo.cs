﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyBase.Domain.Core.Entities;

namespace MyBase.Domain.Interface
{
    public interface IThreadsRepo
    {
        IEnumerable<Thread> GetAllThreads();

        bool AddNewThread(Thread newThread);
    }
}
