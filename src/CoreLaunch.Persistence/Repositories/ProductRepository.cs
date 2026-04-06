using CoreLaunch.Application.Interfaces;
using CoreLaunch.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace CoreLaunch.Persistence.Repositories;

public class ProductRepository : IProductRepository
{
    private readonly ApplicationDbContext _context;

    public ProductRepository(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<List<Product>> GetAllAsync() =>
        await _context.Products.AsNoTracking().ToListAsync();

    public async Task<Product?> GetByIdAsync(int id) =>
        await _context.Products.FindAsync(id);

    public async Task AddAsync(Product product) =>
        await _context.Products.AddAsync(product);
}