using FluentValidation;

namespace CoreLaunch.Application.Features.Products.Commands.CreateProduct;

public class CreateProductCommandValidator : AbstractValidator<CreateProductCommand>
{
    public CreateProductCommandValidator()
    {
        RuleFor(x => x.Name)
            .NotEmpty().WithMessage("Ürün adı boş olamaz!")
            .MaximumLength(100).WithMessage("Ürün adı 100 karakterden uzun olamaz!");

        RuleFor(x => x.Price)
            .GreaterThan(0).WithMessage("Fiyat 0'dan büyük olmalıdır!");

        RuleFor(x => x.Description)
            .MaximumLength(500).WithMessage("Açıklama çok uzun!");
    }
}
