using FluentValidation;

public class ChangeProjectDescriptionValidator : AbstractValidator<ChangeProjectDescriptionDto>
{
    public ChangeProjectDescriptionValidator()
    {
        RuleFor(x => x.Description).NotEmpty().MaximumLength(100);
    }
}