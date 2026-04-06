 using CoreLaunch.Domain.Entities;

namespace CoreLaunch.Application.Interfaces;

public interface IUnitOfWork
{
    IProductRepository Products { get; }
    Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
}