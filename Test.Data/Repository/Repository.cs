using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Data.Repository
{
    /// <summary>
    /// Implement the genaric repository
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class Repository<T> : IRepository<T> where T : class
    {
        private testEntities context;
        private DbSet<T> dbSet;

        #region constrcution

        public Repository(testEntities context)
        {
            this.context = context;
            this.dbSet = context.Set<T>();
        }

        #endregion
        public void Delete(object id)
        {
            try
            {
                T record = dbSet.Find(id);
                dbSet.Attach(record);
                dbSet.Remove(record);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public IEnumerable<T> GetAll()
        {
            return dbSet.ToList();
        }

        public T GetById(object id)
        {
            return dbSet.Find(id);
        }

        public void Insert(T obj)
        {
            try
            {
                dbSet.Add(obj);

            }
            catch (Exception ex)
            {

                throw;
            }
        }

        public void Update(T obj)
        {
            try
            {
                dbSet.Attach(obj);
                context.Entry(obj).State = EntityState.Modified;
            }
            catch (Exception ex)
            {

                throw;
            }
            
        }
    }
}
