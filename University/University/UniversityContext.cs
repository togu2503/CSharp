﻿using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;


namespace University
{
    public partial class UniversityContext : DbContext
    {
        public UniversityContext()
        { }

        public UniversityContext(DbContextOptions<UniversityContext> options)
            :base(options)
        { }

        public virtual DbSet<Teacher> Teacher { get; set; }
        public virtual DbSet<Post> Post { get; set; }
        public virtual DbSet<Study> Study { get; set; }
        public virtual DbSet<TeacherStudyJoint> TeacherStudyJoint { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=PC45\\SQLEXPRESS;Database=university;Trusted_Connection=True;");
            }
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Post>(entity =>
            {
                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasColumnType("varchar")
                    .HasMaxLength(50);

                entity.Property(e => e.Salary)
                    .IsRequired()
                    .HasColumnType("float");
            });
            modelBuilder.Entity<Teacher>(entity =>
            {
                entity.Property(e => e.FullName)
                    .IsRequired()
                    .HasMaxLength(128);
                entity.Property(e => e.Phone)
                    .HasMaxLength(20);
                entity.Property(e => e.WorkAddress)
                    .HasMaxLength(128);
                entity.HasOne(d => d.Post)
                    .WithMany()
                    .HasForeignKey(d => d.PostId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_teacher_post");
                entity.Property(e => e.HomeAddress)
                    .HasMaxLength(128);
                entity.Property(e => e.Characteristic)
                    .HasMaxLength(1000);
            });

            modelBuilder.Entity<Study>(entity =>
            {
                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(128);
            });

            modelBuilder.Entity<TeacherStudyJoint>(entity =>
            {
                entity.HasOne(d => d.Teacher)
                    .WithMany()
                    .HasForeignKey(d => d.TeacherId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_teacher_id");
                entity.HasOne(d => d.Study)
                    .WithMany()
                    .HasForeignKey(d => d.StudyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_study_id");
            });
            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
