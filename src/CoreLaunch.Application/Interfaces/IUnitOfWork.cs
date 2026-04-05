namespace CoreLaunch.Application.Interfaces;

/// <summary>
/// Veritabanı işlemlerinin atomik (tek seferde ve bütünsel) 
/// olarak tamamlanmasını sağlayan Unit of Work arayüzü.
/// </summary>
public interface IUnitOfWork
{
    Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
}
