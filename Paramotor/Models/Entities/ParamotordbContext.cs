using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Paramotor.Models.Entities;

public partial class ParamotordbContext : DbContext
{
    public ParamotordbContext()
    {
    }

    public ParamotordbContext(DbContextOptions<ParamotordbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Site>? Sites { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)

        => optionsBuilder.UseMySql("server=localhost;port=3306;database=paramotordb;user=root", Microsoft.EntityFrameworkCore.ServerVersion.Parse("8.0.27-mysql"));

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder
            .UseCollation("utf8mb4_turkish_ci")
            .HasCharSet("utf8mb4");

        modelBuilder.Entity<Site>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("site");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Description).HasColumnName("description");
            entity.Property(e => e.Email)
                .HasMaxLength(250)
                .HasColumnName("email");
            entity.Property(e => e.Facebook)
                .HasMaxLength(250)
                .HasColumnName("facebook");
            entity.Property(e => e.Instagram)
                .HasMaxLength(250)
                .HasColumnName("instagram");
            entity.Property(e => e.Logoimage)
                .HasMaxLength(250)
                .HasColumnName("logoimage");
            entity.Property(e => e.Title)
                .HasMaxLength(250)
                .HasColumnName("title");
            entity.Property(e => e.Tiwitter)
                .HasMaxLength(250)
                .HasColumnName("tiwitter");
            entity.Property(e => e.Url)
                .HasMaxLength(250)
                .HasColumnName("url");
            entity.Property(e => e.Youtube)
                .HasMaxLength(250)
                .HasColumnName("youtube");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
