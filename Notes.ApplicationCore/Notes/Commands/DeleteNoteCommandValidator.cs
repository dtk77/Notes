using FluentValidation;

namespace Notes.ApplicationCore.Notes.Commands
{
	public class DeleteNoteCommandValidator 
            : AbstractValidator<DeleteNoteCommand>
    {
        public DeleteNoteCommandValidator()
        {
            RuleFor(deleteNoteCommand =>
                deleteNoteCommand.ID).NotEqual(Guid.Empty);
            RuleFor(deleteNoteCommand =>
                deleteNoteCommand.UserId).NotEqual(Guid.Empty);
        }
    }
}