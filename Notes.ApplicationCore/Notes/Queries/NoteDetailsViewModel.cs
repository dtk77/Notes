using Notes.ApplicationCore.Entities;
using AutoMapper;
using Notes.ApplicationCore.Common.Mappings;

namespace Notes.ApplicationCore.Notes.Queries
{
    public class NoteDetailsViewModel : IMapWith<Note>
    {
        public Guid ID { get; set; }
        public string Title { get; set; }
        public string Details { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime? EditDate { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<Note, NoteDetailsViewModel>()
                .ForMember(noteVm => noteVm.Title,
                    opt => opt.MapFrom(note => note.Title))
                .ForMember(noteVm => noteVm.Details,
                    opt => opt.MapFrom(note => note.Details))
                .ForMember(noteVm => noteVm.ID,
                    opt => opt.MapFrom(note => note.ID))
                .ForMember(noteVm => noteVm.CreationDate,
                    opt => opt.MapFrom(note => note.CreateDate))
                .ForMember(noteVm => noteVm.EditDate,
                    opt => opt.MapFrom(note => note.EditDate));
        }
    }
}