using Microsoft.AspNetCore.Mvc;
using MediatR; // Mediatr kullanarak komutu gönderiyoruz
using CoreLaunch.Application.Features.Products.Commands.CreateProduct;

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

    [HttpPost]
    public async Task<IActionResult> Create([FromBody] CreateProductCommand command)
    {
        // Mediatr üzerinden komutu "Application" katmanına fırlatıyoruz!
        var productId = await _mediator.Send(command);
        return Ok(new { Id = productId, Message = "Ürün başarıyla oluşturuldu!" });
    }
}
