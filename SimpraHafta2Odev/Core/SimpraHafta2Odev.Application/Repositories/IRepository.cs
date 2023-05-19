using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SimpraHafta2Odev.Domain.Entity;
using Microsoft.EntityFrameworkCore;

namespace SimpraHafta2Odev.Application.Repositories
{
    public interface IRepository<T> where T : class
    {
        DbSet<T> Table { get; }
    }
}
