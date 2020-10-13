using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;


namespace University
{
    class UniversityContext : DbContext
    {
        public UniversityContext()
        { }

        public UniversityContext(DbContextOptions<UniversityContext> options)
            :base(options)
        { }

        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Teacher> Posts { get; set; }
        public DbSet<Teacher> Studies { get; set; }
        public DbSet<Teacher> TeacherStudyJoints { get; set; }

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
                    .HasColumnType("varchar")
                    .HasMaxLength(128);
                entity.Property(e => e.Phone)
                    .HasColumnType("varchar")
                    .IsRequired();
                entity.Property(e => e.WorkAddress)
                    .HasColumnType("varchar")
                    .IsRequired();
                entity.HasOne(d => d.PostId)
                    .WithMany();


            }
                )
        }
    }
}
