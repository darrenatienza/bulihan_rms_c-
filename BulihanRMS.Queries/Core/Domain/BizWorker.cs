using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BulihanRMS.Queries.Core.Domain
{
    public class BizWorker
    {
        public BizWorker() { }
        public int BizWorkerID { get; set; }
        public virtual PersonalInfo PersonalInfo { get; set; }
        public int PersonalInfoID { get; set; }

        public virtual BizRecord BizRecord { get; set; }
        public int BizRecordID { get; set; }
    }
}
