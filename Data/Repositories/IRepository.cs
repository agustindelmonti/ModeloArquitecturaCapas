﻿using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Data.Repositories
{
    public interface IRepository<TEntity> where TEntity : class
    {
        TEntity GetById(object id);
        IEnumerable<TEntity> Get(Expression<Func<TEntity, bool>> filterExp = null);
        IEnumerable<TEntity> GetOrdered<TKey>(Expression<Func<TEntity, TKey>> orderByExp, Expression<Func<TEntity, bool>> filterExp = null);

        void Add(TEntity entity);
        void AddRange(IEnumerable<TEntity> entities);

        void Delete(object id);
        void Delete(TEntity entity);
        void DeleteRange(IEnumerable<TEntity> entities);

        void Update(TEntity entity);
    }
}