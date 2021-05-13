using MyProject.Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace MyProject.DataAccess.Abstract
{
    public interface IEntityRepository<T>
        where T:class,new()
    {
        List<T> GetAll();
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
        T Get(Expression<Func<T, bool>> filter);
    }
}
