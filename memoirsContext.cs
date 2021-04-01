using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace WebApplicationMemoirs
{
    public partial class memoirsContext : DbContext
    {
        public memoirsContext()
        {
        }

        public memoirsContext(DbContextOptions<memoirsContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Book> Books { get; set; }
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Film> Films { get; set; }
        public virtual DbSet<Game> Games { get; set; }
        public virtual DbSet<Note> Notes { get; set; }
        public virtual DbSet<Person> People { get; set; }
        public virtual DbSet<Picture> Pictures { get; set; }
        public virtual DbSet<Remembrance> Remembrances { get; set; }
        public virtual DbSet<Series> Series { get; set; }
        public virtual DbSet<Tag> Tags { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server= DESKTOP-P7F5N8C\\EREEET; Database=memoirs; Trusted_Connection=True; ");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Cyrillic_General_CI_AS");

            modelBuilder.Entity<Book>(entity =>
            {
                entity.Property(e => e.BookId).HasColumnName("Book_id");

                entity.Property(e => e.BookAddDate)
                    .HasMaxLength(10)
                    .HasColumnName("Book_add_date")
                    .IsFixedLength(true);

                entity.Property(e => e.BookAuthor)
                    .HasMaxLength(10)
                    .HasColumnName("Book_author")
                    .IsFixedLength(true);

                entity.Property(e => e.BookCoverUrl)
                    .HasMaxLength(10)
                    .HasColumnName("Book_cover_url")
                    .IsFixedLength(true);

                entity.Property(e => e.BookInfo)
                    .HasColumnType("text")
                    .HasColumnName("Book_info");

                entity.Property(e => e.BookRate)
                    .HasMaxLength(10)
                    .HasColumnName("Book_rate")
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<Category>(entity =>
            {
                entity.Property(e => e.CategoryId).HasColumnName("Category_id");

                entity.Property(e => e.CatrgoryName)
                    .HasMaxLength(10)
                    .HasColumnName("Catrgory_name")
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<Film>(entity =>
            {
                entity.Property(e => e.FilmId).HasColumnName("Film_id");

                entity.Property(e => e.FilmAddDate)
                    .HasMaxLength(10)
                    .HasColumnName("Film_add_date")
                    .IsFixedLength(true);

                entity.Property(e => e.FilmPosterUrl)
                    .HasMaxLength(10)
                    .HasColumnName("Film_poster_url")
                    .IsFixedLength(true);

                entity.Property(e => e.FilmRate)
                    .HasMaxLength(10)
                    .HasColumnName("Film_rate")
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<Game>(entity =>
            {
                entity.Property(e => e.GameId).HasColumnName("Game_id");

                entity.Property(e => e.GameAddDate)
                    .HasMaxLength(10)
                    .HasColumnName("Game_add_date")
                    .IsFixedLength(true);

                entity.Property(e => e.GameInfo)
                    .HasColumnType("text")
                    .HasColumnName("Game_info");

                entity.Property(e => e.GamePlatform)
                    .HasMaxLength(10)
                    .HasColumnName("Game_platform")
                    .IsFixedLength(true);

                entity.Property(e => e.GamePosterUrl)
                    .HasMaxLength(10)
                    .HasColumnName("Game_poster_url")
                    .IsFixedLength(true);

                entity.Property(e => e.GameRate).HasColumnName("Game_rate");
            });

            modelBuilder.Entity<Note>(entity =>
            {
                entity.HasKey(e => e.NotesId);

                entity.Property(e => e.NotesId).HasColumnName("Notes_id");

                entity.Property(e => e.NoteAddDate)
                    .HasMaxLength(10)
                    .HasColumnName("Note_add_date")
                    .IsFixedLength(true);

                entity.Property(e => e.NoteComment)
                    .HasColumnType("text")
                    .HasColumnName("Note_comment");

                entity.Property(e => e.NoteContentId).HasColumnName("Note_content_id");

                entity.Property(e => e.NoteContentType)
                    .HasMaxLength(10)
                    .HasColumnName("Note_content_type")
                    .IsFixedLength(true);

                entity.Property(e => e.NoteRate).HasColumnName("Note_rate");
            });

            modelBuilder.Entity<Person>(entity =>
            {
                entity.ToTable("Person");

                entity.Property(e => e.PersonId).HasColumnName("Person_id");

                entity.Property(e => e.Email)
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.Property(e => e.Gender)
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.Property(e => e.Name)
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.Property(e => e.Phonenumber)
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.Property(e => e.RegDate)
                    .HasMaxLength(10)
                    .HasColumnName("Reg_date")
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<Picture>(entity =>
            {
                entity.Property(e => e.PictureId).HasColumnName("Picture_id");

                entity.Property(e => e.PictureAddDate)
                    .HasMaxLength(10)
                    .HasColumnName("Picture_add_date")
                    .IsFixedLength(true);

                entity.Property(e => e.PictureComment)
                    .HasColumnType("text")
                    .HasColumnName("Picture_comment");

                entity.Property(e => e.PictureUrl)
                    .HasMaxLength(10)
                    .HasColumnName("Picture_url")
                    .IsFixedLength(true);

                entity.Property(e => e.PitureRate).HasColumnName("Piture_rate");
            });

            modelBuilder.Entity<Remembrance>(entity =>
            {
                entity.Property(e => e.RemembranceId).HasColumnName("Remembrance_id");

                entity.Property(e => e.RemembranceAddDate)
                    .HasMaxLength(10)
                    .HasColumnName("Remembrance_add_date")
                    .IsFixedLength(true);

                entity.Property(e => e.RemembranceComment)
                    .HasColumnType("text")
                    .HasColumnName("Remembrance_comment");

                entity.Property(e => e.RemembranceDate)
                    .HasMaxLength(10)
                    .HasColumnName("Remembrance_date")
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<Series>(entity =>
            {
                entity.Property(e => e.SeriesId).HasColumnName("Series_id");

                entity.Property(e => e.SeriesAddDate)
                    .HasMaxLength(10)
                    .HasColumnName("Series_add_date")
                    .IsFixedLength(true);

                entity.Property(e => e.SeriesPosterUrl)
                    .HasMaxLength(10)
                    .HasColumnName("Series_poster_url")
                    .IsFixedLength(true);

                entity.Property(e => e.SeriesRate).HasColumnName("Series_rate");
            });

            modelBuilder.Entity<Tag>(entity =>
            {
                entity.Property(e => e.TagId).HasColumnName("Tag_id");

                entity.Property(e => e.TagAddDate)
                    .HasMaxLength(10)
                    .HasColumnName("Tag_add_date")
                    .IsFixedLength(true);

                entity.Property(e => e.TagName)
                    .HasMaxLength(10)
                    .HasColumnName("Tag_name")
                    .IsFixedLength(true);

                entity.Property(e => e.TagRate).HasColumnName("Tag_rate");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
