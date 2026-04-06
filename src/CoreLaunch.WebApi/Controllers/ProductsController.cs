 using Microsoft.AspNetCore.Mvc;
using MediatR;
using CoreLaunch.Application.Features.Products.Commands.CreateProduct;
using CoreLaunch.Application.Features.Products.Queries.GetAllProducts;

namespace CoreLaunch.WebAPI.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ProductsController : ControllerBase
{
    private readonly IMediator _mediator;

    public ProductsController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        var products = await _mediator.Send(new GetAllProductsQuery());
        return Ok(products);
    }

    [HttpPost]
    public async Task<IActionResult> Create([FromBody] CreateProductCommand command)
    {
        var productId = await _mediator.Send(command);
        return Ok(new { Id = productId, Message = "Ürün başarıyla oluşturuldu!" });
    }
}