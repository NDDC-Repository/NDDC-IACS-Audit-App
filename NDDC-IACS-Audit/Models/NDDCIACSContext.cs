using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace NDDC_IACS_Audit.Models
{
    public partial class NDDCIACSContext : DbContext
    {
        public NDDCIACSContext()
        {
        }

        public NDDCIACSContext(DbContextOptions<NDDCIACSContext> options)
            : base(options)
        {
        }

        public virtual DbSet<ChecklistTemplate> ChecklistTemplates { get; set; } = null!;
        public virtual DbSet<Directorate> Directorates { get; set; } = null!;
        public virtual DbSet<FileControl> FileControls { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=.;Database=NDDC-IACS;Trusted_Connection=true;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ChecklistTemplate>(entity =>
            {
                entity.ToTable("ChecklistTemplate");

                entity.Property(e => e.AddedBy).HasMaxLength(50);

                entity.Property(e => e.ChecklistItem).HasMaxLength(250);

                entity.Property(e => e.DateAdded).HasColumnType("datetime");
            });

            modelBuilder.Entity<Directorate>(entity =>
            {
                entity.Property(e => e.AddedBy).HasMaxLength(100);

                entity.Property(e => e.DateAdded).HasColumnType("datetime");

                entity.Property(e => e.DirectorateName).HasMaxLength(100);
            });

            modelBuilder.Entity<FileControl>(entity =>
            {
                entity.ToTable("FileControl");

                entity.Property(e => e.AddedBy).HasMaxLength(100);

                entity.Property(e => e.Code).HasMaxLength(50);

                entity.Property(e => e.DateAdded).HasColumnType("datetime");

                entity.Property(e => e.NatureOfTransaction).HasMaxLength(50);

                entity.Property(e => e.Observations).HasColumnType("text");

                entity.Property(e => e.Originator).HasMaxLength(50);

                entity.Property(e => e.OriginatorName).HasMaxLength(250);

                entity.Property(e => e.Remarks).HasColumnType("text");

                entity.Property(e => e.RequestedAmount).HasColumnType("money");

                entity.Property(e => e.Status).HasMaxLength(50);

                entity.Property(e => e.Title).HasMaxLength(520);

                entity.Property(e => e.VettedAmount).HasColumnType("money");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
