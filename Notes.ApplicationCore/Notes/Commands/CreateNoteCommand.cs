using System;
using MediatR;

namespace Notes.ApplicationCore.Notes.Commands
{
    public class CreateNoteCommand : IRequest<Guid>
    {
        public string Details { get; set; }
        public string Title { get; set; }
        public Guid UserId { get; set; }
    }
}
