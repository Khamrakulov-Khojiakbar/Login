using System.Collections.Generic;

namespace Application.Abstractions;

public interface IApplicationDbContext
{
    public DbSet<Users> Users { get; }

    Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
}
