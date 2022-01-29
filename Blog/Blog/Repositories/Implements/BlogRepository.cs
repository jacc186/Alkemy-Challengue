using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web

namespace Blog.Repositories.Implements
{
    internal interface BlogRepository<T> where T : class
    {
        public List<T> GetAllEntities();
        public T Get(int id);
        public T Add(T entity);
        public T Update(T entity);
        public T Delete(int id);
    }
}
