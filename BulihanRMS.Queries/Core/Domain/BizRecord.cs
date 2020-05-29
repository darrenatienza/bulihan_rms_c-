using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BulihanRMS.Queries.Core.Domain
{
    public class BizRecord
    {
        public BizRecord() { }
        public int BizRecordID { get; set; }
        public string BusinessName { get; set; }
        public virtual PersonalInfo PersonalInfo { get; set; }
        public int PersonalInfoID { get; set; }
        public string Address { get; set; }
        public string ContactNumber { get; set; }
        public string ImageName { get; set; }
       
        public ICollection<BizWorker> BizWorker { get; set; }
    }
}
