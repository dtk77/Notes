using System.ComponentModel.DataAnnotations;

namespace Notes.ApplicationCore.Entities
{
    public class NotesBase
    {
        public  DateTime CreateDate { get; set; }
        public DateTime? EditDate { get; set; }
    }
}