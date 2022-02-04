using System.ComponentModel.DataAnnotations;

namespace Notes.ApplicationCore
{
    internal abstract class NotesBase
    {
        public abstract DateTime CreatData { get; set; }
        public abstract DataType? EditDate { get; set; }
    }
}