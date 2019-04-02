using FluentValidation;
using FluentValidation.Validators;

namespace SimelERP.Application.Test.Query.Commands
{
    public class UpdateTestCommandValidator : AbstractValidator<UpdateTestCommand>
    {
        public UpdateTestCommandValidator()
        {
            RuleFor(x => x.TestERPId).NotEmpty();
            RuleFor(x => x.Name).MaximumLength(20).NotEmpty();
            RuleFor(x => x.Text).MaximumLength(50);
        }
    }
}
