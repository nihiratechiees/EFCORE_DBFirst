using System;
using System.Collections.Generic;
using DBFirst.Data.Model;
using Microsoft.EntityFrameworkCore;

namespace DBFirst.Data;

public partial class dbFirstContext : DbContext
{
    public dbFirstContext()
    {
    }

    public dbFirstContext(DbContextOptions<dbFirstContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Associate> Associates { get; set; }

    public virtual DbSet<Product> Products { get; set; }

    public virtual DbSet<TblCustomer> TblCustomers { get; set; }

    public virtual DbSet<User> Users { get; set; }


    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<TblCustomer>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedNever();
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
