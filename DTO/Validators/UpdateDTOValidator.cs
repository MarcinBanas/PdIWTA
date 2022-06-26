using FluentValidation;

namespace PdiwtA.DTO.Validators
{
    public class UpdateDTOValidator : AbstractValidator<UpdateProductDTO>
    {
        public UpdateDTOValidator()
        {

            RuleFor(x => x.Id).NotEmpty();
            RuleFor(x => x.Name).NotEmpty().MinimumLength(2).MaximumLength(30);
            RuleFor(x => x.IsAvailable).NotEmpty();
        }
    }
}
