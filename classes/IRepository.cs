using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OP
{
    public interface IRepository<T>
    {
        void Add(T item);
        void Remove(string name);
        T GetByName(string name);
        List<T> GetAll();
    }
}