using MediatR;

namespace CoreLaunch.Application.Features.Products.Commands.CreateProduct;

/// <summary>
/// Yeni bir ürün oluşturma isteğini temsil eden Command.
/// Geriye oluşturulan ürünün ID'sini (Guid) döner.
/// </summary>
public record CreateProductCommand(
    string Name, 
    decimal Price, 
    string Description
) : IRequest<Guid>;
