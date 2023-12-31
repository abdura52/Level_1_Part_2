﻿using System.Linq.Expressions;
using N70.Identity.Domain.Common;

namespace N70.Identity.Persistence.Repositories.Interfaces;

public interface IEntityRepositoryBase<TEntity> where TEntity : class, IEntity
{
    IQueryable<TEntity> Get(Expression<Func<TEntity, bool>> predicate, bool asNoTracking = true);

    ValueTask<IList<TEntity>> GetByIdsAsync(IEnumerable<Guid> ids, bool asNoTracking = true, CancellationToken cancellationToken = default);

    ValueTask<TEntity?> GetByIdAsync(Guid id, bool asNoTracking = true, CancellationToken cancellationToken = default);

    ValueTask<TEntity> CreateAsync(TEntity entity, bool saveChanges = true, CancellationToken cancellationToken = default);

    ValueTask<TEntity> UpdateAsync(TEntity entity, bool saveChanges = true, CancellationToken cancellationToken = default);

    ValueTask<TEntity?> DeleteAsync(TEntity entity, bool saveChanges = true, CancellationToken cancellationToken = default);

    ValueTask<TEntity?> DeleteByIdAsync(Guid id, bool saveChanges = true, CancellationToken cancellationToken = default);
}