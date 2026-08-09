using FluentValidation;

namespace BlazorBruh.Models;

public class ComplexForm
{
    public string Title { get; set; } = String.Empty;
    public string Description { get; set; } = string.Empty;
    public DateTime NeedDate { get; set; }
    public bool AdditionalConditions { get; set; } = false;
    public string Conditions { get; set; } = string.Empty;
}

public class ComplexFormValidator : AbstractValidator<ComplexForm>
{
    public ComplexFormValidator()
    {
        RuleFor(form => form.Title).NotEmpty().WithMessage("Title is required");
        RuleFor(form => form.Conditions).NotEmpty().When(x => x.AdditionalConditions).WithMessage("Conditions is required if addtitional conditions are checked");
    }
}