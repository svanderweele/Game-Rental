using FluentValidation;
using GameRental.Api.Resources;

namespace GameRental.Api.Validators
{
    public class SaveGameResourceValidator : AbstractValidator<SaveGameResource>
    {
        public SaveGameResourceValidator()
        {
            RuleFor(x => x.Name).NotEmpty().Length(0, 100).WithMessage("Name must not be empty.");
            // RuleFor(x => x.Description).NotEmpty().WithMessage("Description must not be empty");
            // RuleFor(x => x.CoverArtUrl).EmailAddress();
            RuleFor(x => x.GenreIds).NotEmpty().WithMessage("At least one genre must be specified.");
            RuleFor(x => x.ReleaseDate).NotNull().WithMessage("Release date must be specified.");
            RuleFor(x => x.PublisherId).NotEmpty().WithMessage("Publisher needs to specified.");
            RuleFor(x => x.PublisherId).GreaterThan(0).WithMessage("Publisher needs to be valid.");
        }
    }
}