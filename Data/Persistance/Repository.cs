using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Diagnostics;
using System.Linq;
using System.Linq.Expressions;
using Data.Repositories;

/**
 * Repositorio generico para CRUD de entidades
 * Cualquiera que herede de este puede usarlos
 * 
 **/
namespace Data.Persistence
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        protected DbContext Context { get; set;}
        private DbSet<TEntity> _entities;

        public Repository(DbContext _context)
        {
            Context = _context;
            _entities = Context.Set<TEntity>();
        }


        public TEntity GetById(object id)
        {
            return _entities.Find(id);
        }

        public IEnumerable<TEntity> Get(
            Expression<Func<TEntity, bool>> filterExp = null
            )
        {
            IQueryable<TEntity> query = _entities;

            if (filterExp != null)
            {
                query = query.Where(filterExp);
            }

            return query.ToList();
        }

        public IEnumerable<TEntity> GetOrdered<TKey>(
            Expression<Func<TEntity, TKey>> orderByExp,
            Expression<Func<TEntity, bool>> filterExp = null
            )
        {
            Context.Database.Log = message => Trace.Write(message);
            IQueryable<TEntity> query = _entities;

            if (filterExp != null)
            {
                query = query.Where(filterExp);
            }

            return query.OrderBy(orderByExp).ToList();
        }

        public void Add(TEntity entity)
        {
            _entities.Add(entity);
            Context.SaveChanges();
        }

        public void AddRange(IEnumerable<TEntity> entities)
        {
            _entities.AddRange(entities);
            Context.SaveChanges();
        }

        public void Delete(object id)
        {
            TEntity entityToDelete = _entities.Find(id);
            Delete(entityToDelete);
            Context.SaveChanges();
        }

        public void Delete(TEntity entity)
        {
            if (Context.Entry(entity).State == EntityState.Detached)
            {
                _entities.Attach(entity);
            }

            _entities.Remove(entity);
            Context.SaveChanges();
        }

        public void DeleteRange(IEnumerable<TEntity> entities)
        {
            foreach (TEntity entity in entities)
            {
                // REV This may not be necessary
                if (Context.Entry(entity).State == EntityState.Detached)
                {
                    _entities.Attach(entity);
                }
            }
            _entities.RemoveRange(entities);
            Context.SaveChanges();
        }

        public void Update(TEntity entity)
        {
            _entities.Attach(entity);
            Context.Entry(entity).State = EntityState.Modified;
            Context.SaveChanges();
        }
    }
}