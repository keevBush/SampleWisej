using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld.Services
{
    public interface IDataAccess<T> where T:class
    {
        Task<IEnumerable<T>> GetItems(Func<T, bool> where);
        Task<IEnumerable<T>> NewItems(params T[] items);
        Task<T> UpdateItem(T item);
        Task<bool> DeleteItem(Func<T, bool> where);
    }
}
