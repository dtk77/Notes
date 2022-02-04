using Notes.ApplicationCore.Entities;
using Notes.ApplicationCore.Interface;
using MediatR;

namespace Notes.ApplicationCore.Notes.Commands
{
    public class CreateNoteCommandHandler : IRequestHandler<CreateNoteCommand, Guid>
	{
		private readonly INotesDbContext _dbContext;
		public CreateNoteCommandHandler(INotesDbContext dbContext) =>
			_dbContext = dbContext;
		
		public async Task<Guid> Handle(CreateNoteCommand request,
			CancellationToken cancellationToken)
		{
			
			var note = new Note
			{
				ID = Guid.NewGuid(),
				Title = request.Title,
				Details = request.Details,
				UserId = request.UserId,
				CreateData = DateTime.Now,
				EditDate = null
			};
			await _dbContext.Notes.AddAsync(note, cancellationToken);
			await _dbContext.SaveChangesAsync(cancellationToken);	
			
			return note.ID;
		}
	}
}

