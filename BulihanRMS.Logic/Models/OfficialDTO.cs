using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BulihanRMS.Logic.Models
{
    public class OfficialDTO
    {
        public OfficialDTO() { }
        public int ID { get; internal set; }
        public int PersonalInfoID { get; set; }
        public int OfficialGroupID {  get; set; }
        public int OfficialPositionID {  get; set; }
    }
    public class OfficialListDTO
    {
        public OfficialListDTO() { }


        public string FullName { get; set; }

        public string OfficialGroupDescription { get; set; }

        public string OfficialPositionDescription { get; set; }
        public int ID { get; internal set; }

        public string ContactNumber { get; set; }
    }
    
    public class OfficialDetailDTO
    {
        public OfficialDetailDTO() { }


        public string FullName { get; set; }
        public string ContactNumber { get; set; }
       
    }
}
