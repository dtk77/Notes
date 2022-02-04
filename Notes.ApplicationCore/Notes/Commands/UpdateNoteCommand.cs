using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notes.ApplicationCore.Notes.Commands
{
    public class UpdateNoteCommand : IRequest
    {
        public Guid ID { get; set; }
        public string Title { get; set; }
        public string Details { get; set; }
        public Guid UserId { get; set; }
    }
}
