using BulihanRMS.Queries.Core;
using BulihanRMS.Queries.Core.IRepositories;
using BulihanRMS.Queries.Persistence.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BulihanRMS.Queries.Persistence
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly DataContext _context;

        public UnitOfWork(DataContext context)
        {
            _context = context;
            Users = new UserRepository(_context);
            Permissions = new PermissionRepository(_context);
            Childrens = new ChildrenRepo(_context);
            FamilyMedicalHistories = new FamilyMedicalHistoryRepo(_context);
            PastJobs = new PastJobRepo(_context);
            PersonalInfos = new PersonalInfoRepo(_context);
            Officials = new OfficialRepo(_context);
            OfficialGroups = new OfficialGroupRepo(_context);
            OfficialPositions = new OfficialPositionRepo(_context);
            DailyDuties = new DailyDutyRepo(_context);
            Properties = new PropertyRepo(_context);
            PropertyTypes = new PropertyTypeRepo(_context);
            Blotters = new BlotterRepo(_context);
            Indigencies = new IndigencyRepo(_context);
            Residencies = new ResidencyRepo(_context);
            BarangayClearances = new BarangayClearanceRepo(_context);
            BusinessClearances = new BusinessClearanceRepo(_context);
            BizRecords = new BizRecordRepo(_context);
            BizWorkers = new BizWorkerRepo(_context);
        }

        public IUserRepository Users { get; private set; }
        public IPermissionRepository Permissions { get; private set; }
        
        public int Complete()
        {
            return _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }

        public IChildrenRepo Childrens
        {
            get;
            private set;
        }

        public IFamilyMedicalHistoryRepo FamilyMedicalHistories
        {
            get;
            private set;
        }

        public IPastJobRepo PastJobs
        {
            get;
            private set;
        }

        public IPersonalInfoRepo PersonalInfos
        {
            get;
            private set;
        }


        public IOfficialGroupRepo OfficialGroups
        {
            get;
            private set;
        }

        public IOfficialPositionRepo OfficialPositions
        {
            get;
            private set;
        }

        public IOfficialRepo Officials
        {
            get;
            private set;
        }


        public IPropertyRepo Properties
        {
            get;
            private set;
        }

        public IPropertyTypeRepo PropertyTypes
        {
            get;
            private set;
        }

        public IDailyDutyRepo DailyDuties
        {
            get;
            private set;
        }


        public IBlotterRepo Blotters
        {
            get;
            private set;
        }


        public IIndigencyRepo Indigencies
        {
            get;
            private set;
        }


        public IResidencyRepo Residencies
        {
            get;
            private set;
        }


        public IBarangayClearanceRepo BarangayClearances
        {
            get;
            private set;
        }

        public IBusinessClearanceRepo BusinessClearances
        {
            get;
            private set;
        }


        public IBizRecordRepo BizRecords
        {
            get;
            private set;
        }


        public IBizWorkerRepo BizWorkers
        {
            get;
            private set;
        }
    }
}
