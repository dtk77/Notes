using FluentValidation;

namespace Notes.ApplicationCore.Notes.Commands
{
    public class UpdateNoteCommandValidator 
        : AbstractValidator<UpdateNoteCommand>
    {
        public UpdateNoteCommandValidator()
        {
            RuleFor(updateNoteCommand =>
                updateNoteCommand.ID).NotEqual(Guid.Empty);
            RuleFor(updateNoteCommand =>
                updateNoteCommand.Title).NotEmpty().MaximumLength(250);
            RuleFor(updateNoteCommand =>
                updateNoteCommand.UserId).NotEqual(Guid.Empty);
        }
    }
}
