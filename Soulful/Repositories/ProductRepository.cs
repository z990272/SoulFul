using Soulful.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Soulful.Repositories
{
    public class ProductRepository<T> where T : class
    {
        private SoulfulContext _context;
        public SoulfulContext context { get { return _context; } }

        public ProductRepository(SoulfulContext context)
        {
            if (context == null)
            {
                throw new ArgumentNullException();
            }

            _context = context;
        }
        public void Create(T value)
        {
            _context.Entry(value).State = EntityState.Added;
        }
        public void Update(T value)
        {
            _context.Entry(value).State = EntityState.Modified;
        }
        public void Delete(T value)
        {
            _context.Entry(value).State = EntityState.Deleted;
        }
  
        public IQueryable<T> GetAll()
        {
            return _context.Set<T>();
        }
    }
}