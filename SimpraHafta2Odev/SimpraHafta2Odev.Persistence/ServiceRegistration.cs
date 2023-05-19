using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using SimpraHafta2Odev.Application.Repositories.Staffs;
using SimpraHafta2Odev.Application.Repositories;
using SimpraHafta2Odev.Persistence.Contexts;
using SimpraHafta2Odev.Persistence.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpraHafta2Odev.Persistence
{
    public static class ServiceRegistration
    {
        public static void AddPersistenceServices(this IServiceCollection services)
        {
            services.AddDbContext<SimpraHafta2OdevDbContext>(options => options.UseSqlServer(Configurations.ConnectionString), ServiceLifetime.Scoped);
            services.AddScoped<IStaffReadRepository, StaffReadRepository>();
            services.AddScoped<IStaffWriteRepository, StaffWriteRepository>();
        }
    }
}
