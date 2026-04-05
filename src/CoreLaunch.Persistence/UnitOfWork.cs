 using CoreLaunch.Application.Interfaces; 

namespace CoreLaunch.Persistence;

// İsmi düzelttik: IUunitOfWork -> IUnitOfWork ✅
public class UnitOfWork : IUnitOfWork 
{
    private readonly ApplicationDbContext _context;

    public UnitOfWork(ApplicationDbContext context)
    {
        _context = context;
    }

    // Metotlar: Interface ile %100 uyumlu olmalı!
    public async Task<int> SaveChangesAsync()
    {
        return await _context.SaveChangesAsync();
    }

    public async Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
    {
        return await _context.SaveChangesAsync(cancellationToken);
    }
}
