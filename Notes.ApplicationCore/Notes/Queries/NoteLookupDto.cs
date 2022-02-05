using AutoMapper;
using Notes.ApplicationCore.Common.Mappings;
using Notes.ApplicationCore.Entities;

namespace Notes.ApplicationCore.Notes.Queries
{
    public class NoteLookupDto : IMapWith<Note>
    {
        public Guid ID { get; set; }
        public string Title { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<Note, NoteLookupDto>()
                .ForMember(noteDto => noteDto.ID,
                    opt => opt.MapFrom(note => note.ID))
                .ForMember(noteDto => noteDto.Title,
                    opt => opt.MapFrom(note => note.Title));
        }
    }
}