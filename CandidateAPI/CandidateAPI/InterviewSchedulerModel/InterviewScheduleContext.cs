using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace CandidateAPI.InterviewSchedulerModel
{
    public partial class InterviewScheduleContext : DbContext
    {
        public InterviewScheduleContext()
        {
        }

        public InterviewScheduleContext(DbContextOptions<InterviewScheduleContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Candidate> Candidates { get; set; }
        public virtual DbSet<CandidateAvailability> CandidateAvailabilities { get; set; }
        public virtual DbSet<InterviewLevel> InterviewLevels { get; set; }
        public virtual DbSet<InterviewStatus> InterviewStatuses { get; set; }
        public virtual DbSet<Job> Jobs { get; set; }
        public virtual DbSet<Panel> Panels { get; set; }
        public virtual DbSet<PanelAvailability> PanelAvailabilities { get; set; }
        public virtual DbSet<Role> Roles { get; set; }
        public virtual DbSet<Schedule> Schedules { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<UserDetail> UserDetails { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=KANINI-LTP-478\\MSSQLSERVER2019;Database=InterviewSchedule;User ID=sa;Password=Sql@server;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Candidate>(entity =>
            {
                entity.ToTable("Candidate");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Address)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("created_at")
                    .HasDefaultValueSql("(sysdatetime())");

                entity.Property(e => e.Dob)
                    .HasColumnType("date")
                    .HasColumnName("DOB");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.JobId).HasColumnName("JobID");

                entity.Property(e => e.LevelId).HasColumnName("LevelID");

                entity.Property(e => e.Mobileno)
                    .IsRequired()
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedAt).HasColumnName("modified_at");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Qualification)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Resume)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.Job)
                    .WithMany(p => p.Candidates)
                    .HasForeignKey(d => d.JobId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("CJFK");

                entity.HasOne(d => d.Level)
                    .WithMany(p => p.Candidates)
                    .HasForeignKey(d => d.LevelId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("CLFK");
            });

            modelBuilder.Entity<CandidateAvailability>(entity =>
            {
                entity.ToTable("CandidateAvailability");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AvailableDate).HasColumnType("date");

                entity.Property(e => e.CandidateId).HasColumnName("CandidateID");

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("created_at")
                    .HasDefaultValueSql("(sysdatetime())");

                entity.Property(e => e.ModifiedAt).HasColumnName("modified_at");

                entity.HasOne(d => d.Candidate)
                    .WithMany(p => p.CandidateAvailabilities)
                    .HasForeignKey(d => d.CandidateId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("CFK");
            });

            modelBuilder.Entity<InterviewLevel>(entity =>
            {
                entity.ToTable("InterviewLevel");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("created_at")
                    .HasDefaultValueSql("(sysdatetime())");

                entity.Property(e => e.Description)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Level)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedAt).HasColumnName("modified_at");
            });

            modelBuilder.Entity<InterviewStatus>(entity =>
            {
                entity.ToTable("InterviewStatus");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("created_at")
                    .HasDefaultValueSql("(sysdatetime())");

                entity.Property(e => e.ModifiedAt).HasColumnName("modified_at");

                entity.Property(e => e.ScheduleId).HasColumnName("ScheduleID");

                entity.Property(e => e.Status)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.HasOne(d => d.Schedule)
                    .WithMany(p => p.InterviewStatuses)
                    .HasForeignKey(d => d.ScheduleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("SFK");
            });

            modelBuilder.Entity<Job>(entity =>
            {
                entity.ToTable("Job");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("created_at")
                    .HasDefaultValueSql("(sysdatetime())");

                entity.Property(e => e.JobId)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("JOB_ID");

                entity.Property(e => e.JobRole)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedAt).HasColumnName("modified_at");

                entity.Property(e => e.RecStatus)
                    .HasMaxLength(5)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Panel>(entity =>
            {
                entity.ToTable("Panel");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("created_at")
                    .HasDefaultValueSql("(sysdatetime())");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Mobileno)
                    .IsRequired()
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedAt).HasColumnName("modified_at");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.HasOne(d => d.Job)
                    .WithMany(p => p.Panels)
                    .HasForeignKey(d => d.JobId)
                    .HasConstraintName("FK__Panel__JobId__01142BA1");

                entity.HasOne(d => d.Level)
                    .WithMany(p => p.Panels)
                    .HasForeignKey(d => d.LevelId)
                    .HasConstraintName("FK__Panel__LevelId__03F0984C");
            });

            modelBuilder.Entity<PanelAvailability>(entity =>
            {
                entity.ToTable("PanelAvailability");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AvailableDate).HasColumnType("date");

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("created_at")
                    .HasDefaultValueSql("(sysdatetime())");

                entity.Property(e => e.ModifiedAt).HasColumnName("modified_at");

                entity.Property(e => e.PanelId).HasColumnName("Panel_id");

                entity.HasOne(d => d.Panel)
                    .WithMany(p => p.PanelAvailabilities)
                    .HasForeignKey(d => d.PanelId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("PFK");
            });

            modelBuilder.Entity<Role>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("created_at")
                    .HasDefaultValueSql("(sysdatetime())");

                entity.Property(e => e.ModifiedAt).HasColumnName("modified_at");

                entity.Property(e => e.Rolename)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Schedule>(entity =>
            {
                entity.ToTable("Schedule");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CandidateId).HasColumnName("Candidate_id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("created_at")
                    .HasDefaultValueSql("(sysdatetime())");

                entity.Property(e => e.Date).HasColumnType("date");

                entity.Property(e => e.LevelId).HasColumnName("LevelID");

                entity.Property(e => e.ModifiedAt).HasColumnName("modified_at");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PanelId).HasColumnName("Panel_id");

                entity.HasOne(d => d.Candidate)
                    .WithMany(p => p.Schedules)
                    .HasForeignKey(d => d.CandidateId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("CFK1");

                entity.HasOne(d => d.Job)
                    .WithMany(p => p.Schedules)
                    .HasForeignKey(d => d.JobId)
                    .HasConstraintName("FK__Schedule__JobId__14270015");

                entity.HasOne(d => d.Level)
                    .WithMany(p => p.Schedules)
                    .HasForeignKey(d => d.LevelId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("SLFK");

                entity.HasOne(d => d.Panel)
                    .WithMany(p => p.Schedules)
                    .HasForeignKey(d => d.PanelId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("PFK1");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("created_at")
                    .HasDefaultValueSql("(sysdatetime())");

                entity.Property(e => e.ModifiedAt).HasColumnName("modified_at");

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Username)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.Users)
                    .HasForeignKey(d => d.RoleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("RFK");
            });

            modelBuilder.Entity<UserDetail>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Address)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Dob)
                    .HasColumnType("date")
                    .HasColumnName("DOB");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Mobileno)
                    .IsRequired()
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Skills)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.UserDetails)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("UDFK");
            });

            OnModelCreatingPartial(modelBuilder);
        }


        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);


        public override int SaveChanges()
        {
            foreach (var entry in ChangeTracker.Entries())
            {
                var entity = entry.Entity;
                if (entry.State == EntityState.Deleted)
                {
                    entry.State = EntityState.Modified;
                    entity.GetType().GetProperty("RecStatus").SetValue(entity, "D");
                }
            }
            return base.SaveChanges();
        }
    }
}
