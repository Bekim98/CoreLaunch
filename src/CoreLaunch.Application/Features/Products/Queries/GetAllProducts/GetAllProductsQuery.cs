using MediatR;
using CoreLaunch.Domain.Entities;

namespace CoreLaunch.Application.Features.Products.Queries.GetAllProducts;

public record GetAllProductsQuery : IRequest<List<Product>>;