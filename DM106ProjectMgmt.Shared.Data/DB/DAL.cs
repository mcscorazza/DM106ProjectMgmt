using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DM106ProjectMgmt.Shared.Data.DB
{
    public class DAL<T> where T : class
    {
        private readonly DM106ProjectMgmtContext context;
        public DAL(DM106ProjectMgmtContext context)
        {
            this.context = context;
        }
        public void Create(T entity)
        {
            context.Set<T>().Add(entity);
            context.SaveChanges();
        }
        public void Update(T entity)
        {
            context.Set<T>().Update(entity);
            context.SaveChanges();
        }
        public IEnumerable<T> Read()
        {
            return context.Set<T>().ToList();
        }
        public void Delete(T value)
        {
            context.Set<T>().Remove(value);
            context.SaveChanges();
        }
        public T? ReadBy(Func<T, bool> predicate)
        {
            return context.Set<T>().FirstOrDefault(predicate);
        }
    }
}
