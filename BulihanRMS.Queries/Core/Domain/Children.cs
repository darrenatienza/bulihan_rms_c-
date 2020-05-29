using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BulihanRMS.Queries.Core.Domain
{
    public class Children
    {
        public Children() { }
        public int ChildrenID { get; set; }
        public string Name { get; set; }
        public string Age { get; set; }
        public string Occupation { get; set; }
        public virtual PersonalInfo PersonalInfo { get; set; }
        public int PersonalInfoID { get; set; }
    }
}
