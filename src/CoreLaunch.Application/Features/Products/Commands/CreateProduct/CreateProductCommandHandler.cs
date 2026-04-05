using MediatR;
using CoreLaunch.Application.Interfaces;

namespace CoreLaunch.Application.Features.Products.Commands.CreateProduct;

public class CreateProductCommandHandler : IRequestHandler<CreateProductCommand, Guid>
{
    // Not: İleride buraya IUnitOfWork veya IProductRepository enjekte edeceğiz.
    // Şimdilik sadece mantığı gösteriyoruz.

    public async Task<Guid> Handle(CreateProductCommand request, CancellationToken cancellationToken)
    {
        // 1. Adım: Yeni bir ID oluştur (Simülasyon)
        var newProductId = Guid.NewGuid();

        // 2. Adım: İş mantığı (Business Logic)
        // Burada normalde veritabanına kayıt kodu olacak.
        Console.WriteLine($"[LOG]: {request.Name} adlı ürün başarıyla oluşturuldu! ID: {newProductId}");

        // 3. Adım: Geriye yeni oluşan ID'yi dön
        return await Task.FromResult(newProductId);
    }
}
