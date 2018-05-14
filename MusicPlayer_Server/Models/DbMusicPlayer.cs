namespace MusicPlayer_Server.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class DbMusicPlayer : DbContext
    {
        public DbMusicPlayer()
            : base("name=DbMusicPlayer")
        {
        }

        public virtual DbSet<artist> artist { get; set; }
        public virtual DbSet<genre> genre { get; set; }
        public virtual DbSet<login_count> login_count { get; set; }
        public virtual DbSet<playlist> playlist { get; set; }
        public virtual DbSet<playlist_detail> playlist_detail { get; set; }
        public virtual DbSet<rate> rate { get; set; }
        public virtual DbSet<song> song { get; set; }
        public virtual DbSet<sysdiagram> sysdiagram { get; set; }
        public virtual DbSet<user> user { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<artist>()
                .HasMany(e => e.songs)
                .WithRequired(e => e.artist)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<playlist>()
                .HasMany(e => e.playlist_detail)
                .WithRequired(e => e.playlist)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<rate>()
                .Property(e => e.updated_at)
                .HasPrecision(0);

            modelBuilder.Entity<song>()
                .Property(e => e.song_path)
                .IsUnicode(false);

            modelBuilder.Entity<song>()
                .HasMany(e => e.playlist_detail)
                .WithRequired(e => e.song)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<song>()
                .HasMany(e => e.rates)
                .WithRequired(e => e.song)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<user>()
                .Property(e => e.user_name)
                .IsUnicode(false);

            modelBuilder.Entity<user>()
                .Property(e => e.password)
                .IsUnicode(false);

            modelBuilder.Entity<user>()
                .Property(e => e.updated_at)
                .HasPrecision(0);

            modelBuilder.Entity<user>()
                .Property(e => e.email)
                .IsUnicode(false);

            modelBuilder.Entity<user>()
                .HasOptional(e => e.login_count)
                .WithRequired(e => e.user);

            modelBuilder.Entity<user>()
                .HasMany(e => e.playlists)
                .WithRequired(e => e.user)
                .WillCascadeOnDelete(false);
        }
    }
}
