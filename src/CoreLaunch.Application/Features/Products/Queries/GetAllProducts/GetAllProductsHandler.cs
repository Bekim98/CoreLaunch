using MediatR;
using CoreLaunch.Domain.Entities;
using CoreLaunch.Application.Interfaces;

namespace CoreLaunch.Application.Features.Products.Queries.GetAllProducts;

public class GetAllProductsHandler : IRequestHandler<GetAllProductsQuery, List<Product>>
{
    private readonly IUnitOfWork _unitOfWork;

    public GetAllProductsHandler(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }

    public async Task<List<Product>> Handle(GetAllProductsQuery request, CancellationToken cancellationToken)
    {
        return await _unitOfWork.Products.GetAllAsync();
    }
}