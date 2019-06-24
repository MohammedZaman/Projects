using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;


namespace TaxiDriverSystem
{
     public class GenericRepository<T> : IRepository<T> where T: class  // T can only be class, interface, delegate, or array type
    {

        private LinqToSQlDataContext db;
       

        public GenericRepository()
        {
            
            String constr = Properties.Settings.Default.dbString;
            db = new LinqToSQlDataContext(constr);


        }
        

        public void delete(T type)
        {
            try
            {
                db.GetTable<T>().Attach(type);
                db.GetTable<T>().DeleteOnSubmit(type);
                db.Refresh(System.Data.Linq.RefreshMode.KeepCurrentValues, type);
            }
            catch
            {
                Console.WriteLine("Deleted already ");

            }
        }

        public void insert(T type)
        {
            db.GetTable<T>().InsertOnSubmit(type);
        }

        public void save()
        {
            db.SubmitChanges();
        }

        public IEnumerable<T> SelectAll()
        {
             return db.GetTable<T>().ToList<T>();
        }

        public void SelectByID()
        {
            throw new NotImplementedException();
        }

        public void update(T obj)
        {
            db.GetTable<T>().Attach(obj);
            db.Refresh(System.Data.Linq.RefreshMode.KeepCurrentValues, obj);

        }

    
    }
}
