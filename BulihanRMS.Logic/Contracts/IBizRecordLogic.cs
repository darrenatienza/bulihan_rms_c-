using BulihanRMS.Logic.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BulihanRMS.Logic.Contracts
{
    public interface IBizRecordLogic : ILogic<BizRecordDTO>
    {

        List<BizRecordDTO> GetAllBy(string criteria);

        void AddWorker(int bizRecordID, int workerID);

        void RemoveBizWorker(int bizWorkerID);
    }
}
