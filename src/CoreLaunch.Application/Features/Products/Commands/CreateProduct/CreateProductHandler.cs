using MediatR;
using CoreLaunch.Application.Interfaces;
using CoreLaunch.Domain.Entities;

namespace CoreLaunch.Application.Features.Products.Commands.CreateProduct;

public class CreateProductHandler : IRequestHandler<CreateProductCommand, int>
{
    private readonly IUnitOfWork _unitOfWork;

    public CreateProductHandler(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }

    public async Task<int> Handle(CreateProductCommand request, CancellationToken cancellationToken)
    {
        var product = new Product
        {
            Name = request.Name,
            Price = request.Price,
            Description = request.Description
        };

        await _unitOfWork.Products.AddAsync(product);
        await _unitOfWork.SaveChangesAsync(cancellationToken);

        return product.Id;
    }
}