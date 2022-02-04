using System.ComponentModel.DataAnnotations;

namespace Notes.ApplicationCore.Entities
{
    public class NotesBase
    {
        public  DateTime CreatData { get; set; }
        public DataType? EditDate { get; set; }
    }
}