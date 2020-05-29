using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BulihanRMS.Queries.Core.Domain
{
    public class Official
    {
        public Official() { }
        public int OfficialID { get; set; }
        public virtual PersonalInfo PersonalInfo { get; set; }
        public int PersonalInfoID { get; set; }
        public virtual OfficialPosition OfficialPosition { get; set; }
        public int OfficialPositionID { get; set; }
        public virtual OfficialGroup OfficialGroup { get; set; }
        public int OfficialGroupID { get; set; }
    }
}
