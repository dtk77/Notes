using Microsoft.EntityFrameworkCore;
using Notes.ApplicationCore.Interface;
using Notes.ApplicationCore.Entities;
using Notes.Infrastructure.Data.Configuration;

namespace Notes.Infrastructure.Data
{
	public class NotesDbContext : DbContext, INotesDbContext
	{
		public NotesDbContext(DbContextOptions<NotesDbContext> options)
			: base(options) { }
		public DbSet<Note> Notes { get; set; }

		protected override void OnModelCreating(ModelBuilder builder)
		{
			builder.ApplyConfiguration(new NoteConfiguration());
			base.OnModelCreating(builder);
		}
	}
}