using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Yeni_klasör.Models.Entites;

public partial class MydbContext : DbContext
{
    public MydbContext()
    {
    }

    public MydbContext(DbContextOptions<MydbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Todo> Todos { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseMySql("server=localhost;port=3306;database=mydb;user=root;command timeout=120;sslmode=none", Microsoft.EntityFrameworkCore.ServerVersion.Parse("8.0.27-mysql"));

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder
            .UseCollation("utf8mb4_turkish_ci")
            .HasCharSet("utf8mb4");

        modelBuilder.Entity<Todo>(entity =>
        {
            entity.HasKey(e => e.İd).HasName("PRIMARY");

            entity.ToTable("todo");

            entity.Property(e => e.IsComplated).HasColumnType("bit(1)");
            entity.Property(e => e.Title).HasMaxLength(100);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
