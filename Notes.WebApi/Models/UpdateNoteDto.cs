using AutoMapper;
using Notes.ApplicationCore.Common.Mappings;
using Notes.ApplicationCore.Notes.Commands;

namespace Notes.WebApi.Models
{
    public class UpdateNoteDto : IMapWith<UpdateNoteCommand>
    {
        public Guid ID { get; set; }
        public string Title { get; set; }
        public string Details { get; set; }

        public void Mapping (Profile profile)
        {
            profile.CreateMap<UpdateNoteDto, UpdateNoteCommand>()
                .ForMember(noteCommand => noteCommand.ID,
                    opt => opt.MapFrom(noteDto => noteDto.ID))
                .ForMember(noteCommand => noteCommand.Title,
                    opt => opt.MapFrom(noteDto => noteDto.Title))
                .ForMember(noteCommand => noteCommand.Details,
                    opt => opt.MapFrom(noteDto => noteDto.Details));
        }
    }
}
