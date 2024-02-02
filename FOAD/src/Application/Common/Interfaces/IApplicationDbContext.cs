using FOAD.Domain.Entities;

namespace FOAD.Application.Common.Interfaces;
public interface IApplicationDbContext : IDisposable
{
    DbSet<TodoList> TodoLists { get; }

    DbSet<TodoItem> TodoItems { get; }

    Task<int> SaveChangesAsync(CancellationToken cancellationToken);
}
