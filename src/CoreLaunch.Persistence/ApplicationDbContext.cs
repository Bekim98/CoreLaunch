 using Microsoft.EntityFrameworkCore;
using CoreLaunch.Domain.Entities; // Eğer Entity klasörün varsa bunu ekle, yoksa sil!

namespace CoreLaunch.Persistence;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    // Buraya tablolarını (DbSet) ekleyeceksin. Şimdilik boş bırakıyoruz veya örnek ekliyoruz.
    // public DbSet<Product> Products { get; set; } 

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        // Konfigürasyonlar buraya gelecek
    }
}
