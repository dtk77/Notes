using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Notes.ApplicationCore.Common.Exseption;
using Notes.ApplicationCore.Entities;
using Notes.ApplicationCore.Interface;

namespace Notes.ApplicationCore.Notes.Queries
{
    public class GetNoteDetailsQueryHandler
        : IRequestHandler<GetNoteDetailsQuery, NoteDetailsViewModel>
    {
        private readonly INotesDbContext _dbContext;
        private readonly IMapper _mapper;

        public GetNoteDetailsQueryHandler(INotesDbContext dbContext,
           IMapper mapper) => (_dbContext, _mapper) = (dbContext, mapper);

        public async Task<NoteDetailsViewModel> Handle(GetNoteDetailsQuery request,
            CancellationToken cancellationToken)
        {
            var entity = await _dbContext.Notes.
                FirstOrDefaultAsync(note =>
                note.ID == request.ID, cancellationToken);

            if(entity == null || entity.UserId != entity.UserId)
            {
                throw new NotFoundException(nameof(Note), request.ID);
            }
            return _mapper.Map<NoteDetailsViewModel>(entity);
        }
    }
}
