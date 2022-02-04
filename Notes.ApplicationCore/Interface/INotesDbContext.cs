using Microsoft.EntityFrameworkCore;
using Notes.ApplicationCore.Entities;

namespace Notes.ApplicationCore.Interface
{
    public interface INotesDbContext
    {
        DbSet<Note> Notes { get; set; }
        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
    }
}
