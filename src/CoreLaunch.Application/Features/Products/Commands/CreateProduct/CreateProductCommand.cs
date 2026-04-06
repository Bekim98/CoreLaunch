using MediatR;

namespace CoreLaunch.Application.Features.Products.Commands.CreateProduct;

public record CreateProductCommand(string Name, decimal Price, string Description) : IRequest<int>;