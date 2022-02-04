using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Notes.ApplicationCore.Entities;

namespace Notes.Infrastructure.Data.Configuration
{
    public class NoteConfiguration : IEntityTypeConfiguration<Note>
    {
        public void Configure(EntityTypeBuilder<Note> builder)
        {
            builder.HasKey(n=>n.ID);
            builder.HasIndex(n=>n.ID).IsUnique();
            builder.Property(n => n.Title).HasMaxLength(250);
        }
    }
}
