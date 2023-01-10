using FluentValidation;

public class NewProjectValidator : AbstractValidator<CreateProjetDto>
{
    public NewProjectValidator()
    {
        RuleFor(x => x.Name).NotEmpty().MaximumLength(20);
        RuleFor(x => x.Description).NotEmpty().MaximumLength(100);
    }
}