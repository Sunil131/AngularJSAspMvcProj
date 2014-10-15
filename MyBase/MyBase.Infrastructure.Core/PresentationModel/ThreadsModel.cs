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
        public IEnumerable<ThreadDetailModel> Threads { get; set; }
       

    }

    public class ThreadDetailModel
    {
        public int ID { get; set; }
        public string Header { get; set; }
        public string Description { get; set; }
        public string FirstPostId { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedOn { get; set; }
        public int CreaetedBy { get; set; }
    }
}
