﻿using System.Collections.Generic;

namespace Ej2.DAL
{
    public interface IRepository<TEntity>
        where TEntity : class
    {
        void Add(TEntity pEntity);
        void Remove(TEntity pEntity);
        TEntity Get(int pId);
        IEnumerable<TEntity> GetAll();
    }
}
