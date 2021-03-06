﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BulihanRMS.Queries.Core.Domain
{
    public class Residency
    {
        public Residency()
        {

        }
        public int ResidencyID { get; set; }
        public DateTime CreateTimeStamp { get; set; }
        public string LengthOfResidency { get; set; }
        public string RequestedBy { get; set; }
        public virtual PersonalInfo PersonalInfo { get; set;}
        public int PersonalInfoID { get; set; }
    }
}
