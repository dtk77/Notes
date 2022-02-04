using MediatR;

namespace Notes.ApplicationCore.Notes.Commands
{
    public class DeleteNoteCommand : IRequest
    {
        public Guid ID { get; set; }
        public Guid UserId { get; set; }
    }
}
