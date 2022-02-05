using MediatR;

namespace Notes.ApplicationCore.Notes.Queries
{
    public class GetNoteDetailsQuery : IRequest<NoteDetailsViewModel>
    {
        public Guid ID { get; set; }
        public Guid UserId { get; set; }
    }
}
