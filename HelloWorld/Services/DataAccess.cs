using HelloWorld.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace HelloWorld.Services
{
    public class DataAccess<T> : IDataAccess<T> where T : class
    {
        private readonly DataContext _context;
        public DataAccess(DataContext context)
        {
            _context = context;
        }
        public async Task<bool> DeleteItem(Func<T, bool> where)
        {
            var data = _context.Set<T>().Where(where).ToList();
            _context.Set<T>().RemoveRange(data);
            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<IEnumerable<T>> GetItems(Func<T, bool> where)
        {
            await Task.Delay(500);
            return _context.Set<T>().Where(where).ToList();

        }

        public async Task<IEnumerable<T>> NewItems(params T[] items)
        {
            var data = _context.Set<T>().AddRange(items);
            await _context.SaveChangesAsync();
            return data;
        }

        public Task<T> UpdateItem(T item)
        {
            throw new Exception("Use directly with DataContext Class");
        }
    }
}