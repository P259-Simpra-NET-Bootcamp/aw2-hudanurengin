using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SimpraHafta2Odev.Domain.Entity;
using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;


namespace SimpraHafta2Odev.Application.Repositories
{
    public interface IReadRepository<T> : IRepository<T> where T :class
    {

        IQueryable<T> GetAll();
        IQueryable<T> GetWhere(Expression<Func<T, bool>> method);
        
        Task<T> GetSingleAsync(Expression<Func<T, bool>> method);
        Task<T> GetByIdAsync(int id);
    }
}
