using MediatR;
using Notes.ApplicationCore.Common.Exseption;
using Notes.ApplicationCore.Entities;
using Notes.ApplicationCore.Interface;

namespace Notes.ApplicationCore.Notes.Commands
{
    public class DeleteNoteCommandHeandler
        : IRequestHandler<DeleteNoteCommand>
    {
        private readonly INotesDbContext _dbContext;

        public DeleteNoteCommandHeandler(INotesDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<Unit> Handle(DeleteNoteCommand request, CancellationToken cancellationToken)
        {
            var entity = await _dbContext.Notes
                .FindAsync(new object[] {request.ID}, cancellationToken);

            if (entity == null || entity.UserId != request.UserId)
            {
                throw new NotFoundException(nameof(Note), request.ID);
            }

            _dbContext.Notes.Remove(entity);
            await _dbContext.SaveChangesAsync(cancellationToken);

            return Unit.Value;
        }
    }
}
