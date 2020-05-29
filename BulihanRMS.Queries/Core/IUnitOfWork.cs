using BulihanRMS.Queries.Core.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BulihanRMS.Queries.Core
{
    public interface IUnitOfWork : IDisposable
    {
        IUserRepository Users { get;}
        IPermissionRepository Permissions { get;}

        IChildrenRepo Childrens { get; }
        IFamilyMedicalHistoryRepo FamilyMedicalHistories { get; }
        IPastJobRepo PastJobs { get; }
        IPersonalInfoRepo PersonalInfos { get; }
        IOfficialGroupRepo OfficialGroups { get; }
        IOfficialPositionRepo OfficialPositions { get; }
        IOfficialRepo Officials { get; }
        IPropertyRepo Properties { get; }
        IPropertyTypeRepo PropertyTypes { get; }
        IDailyDutyRepo DailyDuties { get; }
        IBlotterRepo Blotters { get; }
        IIndigencyRepo Indigencies { get; }
        IResidencyRepo Residencies { get; }
        IBarangayClearanceRepo BarangayClearances { get; }
        IBusinessClearanceRepo BusinessClearances { get; }
        IBizRecordRepo BizRecords { get; }
        IBizWorkerRepo BizWorkers { get; }
        int Complete();
    }
}
