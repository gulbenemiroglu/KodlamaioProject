using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Core.DataAccess
{
    // generic constraint
    public interface IEntityRepository<T> where T : class, IEntity, new()
    {
        // p=> p.id==2 gibi filtreleme yapmamızı sağlar. filter=null filtre yazmasak da olur demektir.
        List<T> GetAll(Expression<Func<T, bool>> filter = null);
        T Get(Expression<Func<T, bool>> filter);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
        
    }
}
