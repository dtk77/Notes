using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notes.ApplicationCore
{
    internal class Notes : NotesBase
    {
        public Guid ID { get; set; }
        public string Title { get; set; }
        public string Details { get; set; }
        public override DateTime CreatData { get; set; }
        public override DataType? EditDate { get; set; }

       
        public Guid UserId { get; set; }
    }
}
