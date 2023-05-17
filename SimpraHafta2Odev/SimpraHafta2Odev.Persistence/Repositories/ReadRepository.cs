using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SimpraHafta2Odev.Application.Repositories;
using SimpraHafta2Odev.Domain.Entity;
using SimpraHafta2Odev.Persistence.Contexts;

namespace SimpraHafta2Odev.Persistence.Repositories
{
    public class ReadRepository<T> : IReadRepository<T> where T : class

    {
        private readonly SimpraHafta2OdevDbContext _context;

        public ReadRepository(SimpraHafta2OdevDbContext context)
        {
            _context = context;
        }

        public DbSet<T> Table => _context.Set<T>();

        public IQueryable<T> GetAll()
            => Table;

        public IQueryable<T> GetWhere(Expression<Func<T, bool>> method)
            => Table.Where(method);

        public async Task<T> GetSingleAsync(Expression<Func<T, bool>> method)
            => await Table.FirstOrDefaultAsync(method);

        public async Task<T> GetByIdAsync(int id)
            => await Table.FindAsync(id);


    }
}

