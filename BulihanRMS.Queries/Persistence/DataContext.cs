using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using BulihanRMS.Queries.Core.Domain;
using BulihanRMS.Queries.Migrations;
using BulihanRMS.Queries.EntityConfiguration;
namespace BulihanRMS.Queries.Persistence
{
    public class DataContext : DbContext
    {
        public DataContext()
            //: base("DataContext")
             : base("ReleaseContext")
        {
            this.Configuration.LazyLoadingEnabled = false;
        }

        public virtual DbSet<User> Users { get; set; }
        //public virtual DbSet<Permission> Permissions { get; set; }

        public virtual DbSet<Children> Childrens { get; set; }
        public virtual DbSet<FamilyMedicalHistory> FamilyMedicalHistories { get; set; }
        public virtual DbSet<PastJob> PastJobs { get; set; }
        public virtual DbSet<PersonalInfo> PersonalInfos { get; set; }

        public virtual DbSet<Official> Officials { get; set; }
        public virtual DbSet<OfficialGroup> OfficialGroups { get; set; }
        public virtual DbSet<OfficialPosition> OfficialPositions { get; set; }
        public virtual DbSet<DailyDuty> DailyDuties { get; set; }
        public virtual DbSet<Property> Properties { get; set; }
        public virtual DbSet<PropertyType> PropertyTypes { get; set; }
        public virtual DbSet<Blotter> Blotters { get; set; }
        public virtual DbSet<Indigency> Indigencies { get; set; }
        public virtual DbSet<Residency> Residencies { get; set; }
        public virtual DbSet<BarangayClearance> BarangayClearances { get; set; }
        public virtual DbSet<BusinessClearance> BusinessClearances { get; set; }
        public virtual DbSet<BizRecord> BizRecords { get; set; }
        public virtual DbSet<BizWorker> BizWorkers { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //modelBuilder.Configurations.Add(new BizWorkerConfig());
            
        }



        
    }
}
