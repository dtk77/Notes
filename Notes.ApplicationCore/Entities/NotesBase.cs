using System.ComponentModel.DataAnnotations;

namespace Notes.ApplicationCore.Entities
{
    public class NotesBase
    {
        public  DateTime CreateData { get; set; }
        public DateTime? EditDate { get; set; }
    }
}