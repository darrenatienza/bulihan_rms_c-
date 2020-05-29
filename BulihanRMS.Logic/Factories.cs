using BulihanRMS.Logic.Contracts;
using BulihanRMS.Logic.Implementors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BulihanRMS.Logic
{
    public static class Factories
    {
        public static IPersonalInfoLogic CreatePersonalInfo()
        {
            return new PersonalInfoLogic();
        }
        public static IChildrenLogic CreateChildren()
        {
            return new ChildrenLogic();
        }

        public static IFamilyMedicalHistoryLogic CreateFamilyMedicalHistory()
        {
            return new FamilyMedicalHistoryLogic();
        }
        public static IPastJobLogic CreatePastJob()
        {
            return new PastJobLogic();
        }
        public static IOfficialPositionLogic CreateOfficialPosition()
        {
            return new OfficialPositionLogic();
        }
        public static IOfficialLogic CreateOfficialLogic()
        {
            return new OfficialLogic();
        }
        public static IOfficialGroupLogic CreateOfficialGroup()
        {
            return new OfficialGroupLogic();
        }


        public static IPropertyLogic CreateProperty()
        {
            return new PropertyLogic();
        }

        public static IPropertyTypeLogic CreatePropertyType()
        {
            return new PropertyTypeLogic();
        }

        public static IDailyDutyLogic CreateDailyDuty()
        {
            return new DailyDutyLogic();
        }

        public static IBlotterLogic CreateBlotter()
        {
            return new BlotterLogic();
        }

        public static IResidencyLogic CreateResidency()
        {
            return new ResidencyLogic();
        }

        public static IIndigencyLogic CreateIndigency()
        {
            return new IndigencyLogic();
        }

        public static IBrgyClearanceLogic CreateBrgyClearance()
        {
            return new BrgyClearanceLogic();
        }

        public static IBusinessClearanceLogic CreateBrgyBizClearance()
        {
            return new BusinessClearanceLogic();
        }

        public static IDashboardSummaryLogic CreateDashboardSummary()
        {
            return new DashboardSummaryLogic();
        }

        public static IUserLogic CreateUser()
        {
            return new UserLogic();
        }

        public static IBizRecordLogic CreateBizRecord()
        {
            return new BizRecordLogic();
        }
    }
}
