using BulihanRMS.Queries.Core.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BulihanRMS.Logic.Models
{
    public class BizRecordDTO
    {
        public BizRecordDTO() {
            BizWorkers = new List<BizWorkerDTO>();
        }
        public int ID { get; internal set; }

        public string BizName { get; set; }
        public string OwnerName { get; set; }
        public int OwnerID { get; set; }
        public string BizAddress { get; set; }
        public string BizContactNumber { get; set; }
        public string ImageName { get; set; }
        public List<BizWorkerDTO> BizWorkers { get; set; }
       
    }
    public class BizWorkerDTO
    {
        public BizWorkerDTO() { }
        public int ID { get; internal set; }

        public string FullName { get; set; }
        public string Address { get; set; }
        public string ContactNumber { get; set; }
        public string PermanentAddress { get; set; }

    }
   
}
