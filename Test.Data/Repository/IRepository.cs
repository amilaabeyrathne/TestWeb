using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Data.Repository
{
    /// <summary>
    /// Declare genaric reository interface
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IRepository<T> where T:class
    {
        IEnumerable<T> GetAll();
        T GetById(object id);
        void Delete(object id);
        void Update(T obj);

        void Insert(T obj);
    }
}
