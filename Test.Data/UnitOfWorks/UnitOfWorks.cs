using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.Data.Repository;

namespace Test.Data.UnitOfWorks
{
    public class UnitOfWorks : IDisposable
    {
        private testEntities context = new testEntities();
        private Repository<Student> studentRopository;

        public Repository<Student> StudentRopository
        {
            get {
                if (this.studentRopository == null)
                {
                    this.studentRopository = new Repository<Student>(context);

                }
                return studentRopository;
            }   
        }

        public void Save()
        {
            context.SaveChanges();
        }

        private bool disposed = false;

        public  void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    context.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
