using FluentValidation;

namespace PdiwtA.DTO.Validators
{
    public class TestUserDTOValidator : AbstractValidator<TestUserDTO>
    {
        public TestUserDTOValidator()
        {
            RuleFor(x => x.Email).NotEmpty().MaximumLength(30);
            RuleFor(x => x.Phone).NotEmpty().Length(9);
        }
    }
}
