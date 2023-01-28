using System;
using System.Collections.Generic;
using ESFCustomersData.Models;
using Microsoft.EntityFrameworkCore;

namespace ESFCustomersData.Data;

public partial class CustomersDbContext : DbContext
{
    public CustomersDbContext(DbContextOptions<CustomersDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Symvolaia>? symvolaia { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) { }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.UseCollation("SQL_Latin1_General_CP1253_CI_AI");

        modelBuilder.Entity<Symvolaia>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("symvolaia");

            entity.Property(e => e.CUSCODE)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.CUSNAME)
                .HasMaxLength(128)
                .IsUnicode(false);
            entity.Property(e => e.LSALEDATE).HasColumnType("datetime");
            entity.Property(e => e.MCODE)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.MNAME)
                .HasMaxLength(128)
                .IsUnicode(false);
            entity.Property(e => e.afm)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.date01).HasColumnType("datetime");
            entity.Property(e => e.fpist)
                .HasMaxLength(80)
                .IsUnicode(false);
            entity.Property(e => e.phone01)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.phone02)
                .HasMaxLength(20)
                .IsUnicode(false);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}




//Scaffold-DbContext Name=ConnectionStrings:DefaultConnectionString Microsoft.EntityFrameworkCore.SqlServer -OutputDir Models -Context CustomersDbContext -Tables "symvolaia"
