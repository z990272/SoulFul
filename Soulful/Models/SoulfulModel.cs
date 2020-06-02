namespace Soulful
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class SoulfulModel : DbContext
    {
        public SoulfulModel()
            : base("name=SoulfulContext")
        {
        }

        public virtual DbSet<Album> Album { get; set; }
        public virtual DbSet<Buy> Buy { get; set; }
        public virtual DbSet<Event> Event { get; set; }
        public virtual DbSet<Language> Language { get; set; }
        public virtual DbSet<News> News { get; set; }
        public virtual DbSet<Singer> Singer { get; set; }
        public virtual DbSet<Song> Song { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Album>()
                .HasMany(e => e.Buy)
                .WithRequired(e => e.Album)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Album>()
                .HasMany(e => e.Song)
                .WithRequired(e => e.Album)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Buy>()
                .Property(e => e.Price)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Event>()
                .Property(e => e.Price)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Language>()
                .HasMany(e => e.Singer)
                .WithRequired(e => e.Language)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Language>()
                .HasMany(e => e.Song)
                .WithRequired(e => e.Language)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Singer>()
                .HasMany(e => e.Album)
                .WithRequired(e => e.Singer)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Singer>()
                .HasMany(e => e.Event)
                .WithRequired(e => e.Singer)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Singer>()
                .HasMany(e => e.News)
                .WithRequired(e => e.Singer)
                .WillCascadeOnDelete(false);
        }
    }
}
