using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SimpraHafta2Odev.Application.Repositories;
using SimpraHafta2Odev.Application.Repositories.Staffs;
using SimpraHafta2Odev.Domain.Entity;
using SimpraHafta2Odev.Persistence.Contexts;

namespace SimpraHafta2Odev.Persistence.Repositories
{
    public class StaffReadRepository : ReadRepository<Staff>, IStaffReadRepository
    {
        public StaffReadRepository(SimpraHafta2OdevDbContext context) : base(context)
        {
        }
    }
}
