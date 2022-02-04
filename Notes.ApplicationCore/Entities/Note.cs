using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notes.ApplicationCore.Entities
{
    public class Note : NotesBase
    {
        public Guid ID { get; set; }
        public string Title { get; set; }
        public string Details { get; set; }

        public Guid UserId { get; set; }

    }
}
