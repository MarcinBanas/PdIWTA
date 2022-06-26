using FluentValidation;

namespace PdiwtA.DTO.Validators
{
    public class AddProductDTOValidator : AbstractValidator<AddProductDTO>
    {
        public AddProductDTOValidator()
        {
            RuleFor(x => x.Id).NotEmpty();
            RuleFor(x => x.Name).NotEmpty().MinimumLength(2).MaximumLength(30);
            RuleFor(x => x.IsAvailable).NotEmpty();
        }
    }
}
