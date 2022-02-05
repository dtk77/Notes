﻿using AutoMapper;
using AutoMapper.QueryableExtensions;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Notes.ApplicationCore.Interface;

namespace Notes.ApplicationCore.Notes.Queries
{
    public class GetNoteListQueryHandler
       : IRequestHandler<GetNoteListQuery, NoteListViewModel>
    {
        private readonly INotesDbContext _dbContext;
        private readonly IMapper _mapper;

        public GetNoteListQueryHandler(INotesDbContext dbContext,
            IMapper mapper) =>
            (_dbContext, _mapper) = (dbContext, mapper);

        public async Task<NoteListViewModel> Handle(GetNoteListQuery request,
            CancellationToken cancellationToken)
        {
            var notesQuery = await _dbContext.Notes
                .Where(note => note.UserId == request.UserId)
                .ProjectTo<NoteLookupDto>(_mapper.ConfigurationProvider)
                .ToListAsync(cancellationToken);

            return new NoteListViewModel { Notes = notesQuery };
        }
    }
}