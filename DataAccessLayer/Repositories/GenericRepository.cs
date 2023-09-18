using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
    public class GenericRepository<T> : IGenericDal<T> where T : class
    {
        public void Delete(T t)
        {
            using var a = new Context();
            a.Remove(t);
            a.SaveChanges();
        }

        public T GetByID(int id)
        {
            using var a = new Context();
            //Menim yazdigim test edersen
            //var findid = a.Find<T>(id);
            var findid = a.Set<T>().Find(id);
            return findid;
        }

        public List<T> GetListAll()
        {
            using var a = new Context();
            var Getlist = a.Set<T>().ToList();
            return Getlist;
        }

        public void Insert(T t)
        {
            using var a = new Context();
            a.Add(t);
            a.SaveChanges();
        }

        public List<T> GetListAll(Expression<Func<T, bool>> filter)
        {
            using var c = new Context();

            return c.Set<T>().Where(filter).ToList();

        }

        public void Update(T t)
        {
            using var a = new Context();
            a.Update(t);
            a.SaveChanges();
        }
    }
}
