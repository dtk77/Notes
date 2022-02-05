using MediatR;

namespace Notes.ApplicationCore.Notes.Queries
{
	public class GetNoteListQuery : IRequest<NoteListViewModel>
    {
        public Guid UserId { get; set; }
    }
}