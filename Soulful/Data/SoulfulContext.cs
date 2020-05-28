namespace Soulful.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class SoulfulContext : DbContext
    {
        public SoulfulContext()
            : base("name=SoulfulContext")
        {
        }

        public virtual DbSet<C__MigrationHistory> C__MigrationHistory { get; set; }
        public virtual DbSet<Album> Album { get; set; }
        public virtual DbSet<AspNetRoles> AspNetRoles { get; set; }
        public virtual DbSet<AspNetUserClaims> AspNetUserClaims { get; set; }
        public virtual DbSet<AspNetUserLogins> AspNetUserLogins { get; set; }
        public virtual DbSet<AspNetUsers> AspNetUsers { get; set; }
        public virtual DbSet<Buy> Buy { get; set; }
        public virtual DbSet<Event> Event { get; set; }
        public virtual DbSet<Language> Language { get; set; }
        public virtual DbSet<Like> Like { get; set; }
        public virtual DbSet<News> News { get; set; }
        public virtual DbSet<Singer> Singer { get; set; }
        public virtual DbSet<Song> Song { get; set; }
        public virtual DbSet<Style> Style { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Album>()
                .Property(e => e.Price)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Album>()
                .HasMany(e => e.Buy)
                .WithRequired(e => e.Album)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Album>()
                .HasMany(e => e.Song)
                .WithRequired(e => e.Album)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Album>()
                .HasMany(e => e.Style)
                .WithRequired(e => e.Album)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<AspNetRoles>()
                .HasMany(e => e.AspNetUsers)
                .WithMany(e => e.AspNetRoles)
                .Map(m => m.ToTable("AspNetUserRoles").MapLeftKey("RoleId").MapRightKey("UserId"));

            modelBuilder.Entity<AspNetUsers>()
                .HasMany(e => e.AspNetUserClaims)
                .WithRequired(e => e.AspNetUsers)
                .HasForeignKey(e => e.UserId);

            modelBuilder.Entity<AspNetUsers>()
                .HasMany(e => e.AspNetUserLogins)
                .WithRequired(e => e.AspNetUsers)
                .HasForeignKey(e => e.UserId);

            modelBuilder.Entity<AspNetUsers>()
                .HasMany(e => e.Buy)
                .WithRequired(e => e.AspNetUsers)
                .HasForeignKey(e => e.User_id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<AspNetUsers>()
                .HasMany(e => e.Like)
                .WithRequired(e => e.AspNetUsers)
                .HasForeignKey(e => e.User_id)
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

            modelBuilder.Entity<Song>()
                .HasMany(e => e.Like)
                .WithRequired(e => e.Song)
                .WillCascadeOnDelete(false);
        }
    }
}
