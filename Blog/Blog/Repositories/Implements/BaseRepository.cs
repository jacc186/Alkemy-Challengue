using Blog.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Repositories.Implements
{
    public abstract class BaseRepository<TEntity, Tcontext> : BlogRepository<TEntity> where TEntity : class where Tcontext : BlogContext
    {
        private readonly Tcontext _blogContext;
        protected BaseRepository(Tcontext blogContext)
        {
            _blogContext = blogContext;
        }
        public List<TEntity> GetAllEntities()
        {
            return _blogContext.Set<TEntity>().ToList();
        }
        public TEntity Get(int id)
        {

            return _blogContext.Set<TEntity>().Find(id);
        }
        public TEntity Add(TEntity entity)
        {
            _blogContext.Set<TEntity>().Add(entity);
            _blogContext.SaveChanges();
            return entity;
        }
        public TEntity Update(TEntity entity)
        {
            if (entity != null)
            {
                _blogContext.Set<TEntity>().Update(entity);
                return entity;
            }
            return null;
        }
        public TEntity Delete(int id)
        {
            throw new NotImplementedException();
        }
    }
}
