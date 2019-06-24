using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxiDriverSystem
{
    public interface IRepository<T> where T:class
    {
        IEnumerable<T> SelectAll();
        void SelectByID();
        void insert(T type);
        void update(T type);
        void delete(T type);
        void save();
    }
}
