using Antlia.MovManual.Domain.Contratos.Dominios;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Antlia.MovManual.Domain.Contratos.Repositorios
{
    public interface IGenericRepository<TEntity> : IBaseRepository
        where TEntity : class, IEntity
    {
        Task<TEntity> Get(int id);
        Task<TEntity> Get(int id, params Expression<Func<TEntity, object>>[] properties);

        Task<IEnumerable<TEntity>> GetAll();
        Task<IEnumerable<TEntity>> GetAll(params Expression<Func<TEntity, object>>[] properties);

        Task<TEntity> Find(Expression<Func<TEntity, bool>> match);
        Task<TEntity> Find(Expression<Func<TEntity, bool>> match, params Expression<Func<TEntity, object>>[] properties);

        Task<IEnumerable<TEntity>> FindAll(Expression<Func<TEntity, bool>> match);
        Task<IEnumerable<TEntity>> FindAll(Expression<Func<TEntity, bool>> match, params Expression<Func<TEntity, object>>[] properties);

        Task Create(TEntity entity);
        Task Update(TEntity entity);
        Task Delete(int id);

        Task<int> Count();
    }
}
