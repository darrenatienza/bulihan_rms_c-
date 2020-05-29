using BulihanRMS.Logic.Contracts;
using BulihanRMS.Logic.Models;
using BulihanRMS.Queries.Core.Domain;
using BulihanRMS.Queries.Persistence;
using Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BulihanRMS.Logic.Implementors
{
    public class DashboardSummaryLogic : IDashboardSummaryLogic
    {

        public DashboardSummaryDTO Get()
        {
            using (var uow = new UnitOfWork(new DataContext()))
            {
                var dto = new DashboardSummaryDTO();
                dto.BizClearanceMonthlyCount = uow.BusinessClearances.GetMonthlyCount();
                dto.BizClearanceTodayCount = uow.BusinessClearances.GetTodayCount();
                dto.BizClearanceWeeklyCount = uow.BusinessClearances.GetWeeklyCount();

                dto.BrgyClearanceMonthlyCount = uow.BarangayClearances.GetMonthlyCount();
                dto.BrgyClearanceTodayCount = uow.BarangayClearances.GetTodayCount();
                dto.BrgyClearanceWeeklyCount = uow.BarangayClearances.GetWeeklyCount();

                dto.PersonalInfoMonthlyCount = uow.PersonalInfos.GetMonthlyCount();
                dto.PersonalInfoTodayCount = uow.PersonalInfos.GetTodayCount();
                dto.PersonalInfoWeeklyCount = uow.PersonalInfos.GetWeeklyCount();
                dto.PersonalInfoTotalCount = uow.PersonalInfos.GetTotalResidentCount();
                return dto;
            }
        }
    }
}
