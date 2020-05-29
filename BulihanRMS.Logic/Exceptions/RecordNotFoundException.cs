using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BulihanRMS.Logic.Exceptions
{
    [Serializable]
    public class RecordNotFoundException :Exception
    {
        public RecordNotFoundException()
        {

        }
        public RecordNotFoundException(string objectName) : base(String.Format("Record not found for : {0}", objectName)) { }
    }
}
