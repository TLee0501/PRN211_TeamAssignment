using System;
using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.Extensions.Configuration;

#nullable disable

namespace BusinessObjects
{
    public partial class PRN211_IT_HR_Management_SystemContext : DbContext
    {
        public PRN211_IT_HR_Management_SystemContext()
        {
        }

        public PRN211_IT_HR_Management_SystemContext(DbContextOptions<PRN211_IT_HR_Management_SystemContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Attendance> Attendances { get; set; }
        public virtual DbSet<Candidate> Candidates { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<Overtime> Overtimes { get; set; }
        public virtual DbSet<Payslip> Payslips { get; set; }
        public virtual DbSet<Salary> Salaries { get; set; }
        public virtual DbSet<TakeLeave> TakeLeaves { get; set; }
        public virtual DbSet<TakeLeaveCount> TakeLeaveCounts { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(GetConnectionString());
                //optionsBuilder.UseSqlServer("Server=(local);uid=sa;pwd=12345678;database=PRN211_IT_HR_Management_System;TrustServerCertificate=True");
            }
        }

        private string GetConnectionString()
        {
            IConfiguration configuration = new ConfigurationBuilder()
                    .SetBasePath(Directory.GetCurrentDirectory())
                    .AddJsonFile("appsettings.json", true, true).Build();
            return configuration["ConnectionStrings:DefaultConnectionString"];
        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Attendance>(entity =>
            {
                entity.ToTable("Attendance");

                entity.Property(e => e.AttendanceId).HasColumnName("AttendanceID");

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");

                entity.Property(e => e.IsAttend).HasColumnName("isAttend");

                entity.HasOne(d => d.Employee)
                    .WithMany(p => p.Attendances)
                    .HasForeignKey(d => d.EmployeeId)
                    .HasConstraintName("FK_Attendance_Employee");
            });

            modelBuilder.Entity<Candidate>(entity =>
            {
                entity.ToTable("Candidate");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Description)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Employee>(entity =>
            {
                entity.ToTable("Employee");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Email).IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Password)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RoleName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Username)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Overtime>(entity =>
            {
                entity.ToTable("Overtime");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Date).HasColumnType("date");

                entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");

                entity.HasOne(d => d.Employee)
                    .WithMany(p => p.Overtimes)
                    .HasForeignKey(d => d.EmployeeId)
                    .HasConstraintName("FK_Overtime_Employee");
            });

            modelBuilder.Entity<Payslip>(entity =>
            {
                entity.ToTable("Payslip");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.BonusOt).HasColumnName("BonusOT");

                entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");

                entity.HasOne(d => d.Employee)
                    .WithMany(p => p.Payslips)
                    .HasForeignKey(d => d.EmployeeId)
                    .HasConstraintName("FK_Payslip_Employee");
            });

            modelBuilder.Entity<Salary>(entity =>
            {
                entity.ToTable("Salary");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");

                entity.HasOne(d => d.Employee)
                    .WithMany(p => p.Salaries)
                    .HasForeignKey(d => d.EmployeeId)
                    .HasConstraintName("FK_Salary_Employee");
            });

            modelBuilder.Entity<TakeLeave>(entity =>
            {
                entity.ToTable("TakeLeave");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Description)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");

                entity.Property(e => e.EndDate).HasColumnType("date");

                entity.Property(e => e.IsAccept).HasColumnName("isAccept");

                entity.Property(e => e.StartDate).HasColumnType("date");

                entity.HasOne(d => d.Employee)
                    .WithMany(p => p.TakeLeaves)
                    .HasForeignKey(d => d.EmployeeId)
                    .HasConstraintName("FK_TakeLeave_Employee");
            });

            modelBuilder.Entity<TakeLeaveCount>(entity =>
            {
                entity.ToTable("TakeLeaveCount");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");

                entity.HasOne(d => d.Employee)
                    .WithMany(p => p.TakeLeaveCounts)
                    .HasForeignKey(d => d.EmployeeId)
                    .HasConstraintName("FK_TakeLeaveCount_Employee");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
