using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace GC.RESUME.CORE.DAL.Entities
{
    public partial class ResumeContext : DbContext
    {
        public ResumeContext()
        {
        }

        public ResumeContext(DbContextOptions<ResumeContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Award> Award { get; set; }
        public virtual DbSet<Certification> Certifications { get; set; }
        public virtual DbSet<Education> Educations { get; set; }
        public virtual DbSet<email> Emails { get; set; }
        public virtual DbSet<Experience> Experiences { get; set; }
        public virtual DbSet<Language> Languages { get; set; }
        public virtual DbSet<Link> Links { get; set; }
        public virtual DbSet<Phone> Phones { get; set; }
        public virtual DbSet<Profile> Profiles { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Workflow> Workflows { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
//            if (!optionsBuilder.IsConfigured)
//            {
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
//                optionsBuilder.UseSqlServer("");
//            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Award>(entity =>
            {
                entity.ToTable("Awards");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CompName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("compName");

                entity.Property(e => e.Location)
                    .HasMaxLength(50)
                    .HasColumnName("location");

                entity.Property(e => e.Place)
                    .IsRequired()
                    .HasMaxLength(3)
                    .HasColumnName("place")
                    .IsFixedLength(true);

                entity.Property(e => e.ProfileId).HasColumnName("profileId");

                entity.Property(e => e.YearRec).HasColumnName("yearRec");

                entity.HasOne(d => d.Profile)
                    .WithMany(p => p.Awards)
                    .HasForeignKey(d => d.ProfileId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Awards_profile");
            });

            modelBuilder.Entity<Certification>(entity =>
            {
                entity.ToTable("certification");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CertTitle)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("certTitle");

                entity.Property(e => e.ProfileId).HasColumnName("profileId");

                entity.Property(e => e.recievedFrom)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("recievedFrom");

                entity.HasOne(d => d.Profile)
                    .WithMany(p => p.Certifications)
                    .HasForeignKey(d => d.ProfileId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_certification_profile");
            });

            modelBuilder.Entity<Education>(entity =>
            {
                entity.ToTable("education");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.DegreePath)
                    .HasColumnType("text")
                    .HasColumnName("degreePath");

                entity.Property(e => e.DegreeTitle)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("degreeTitle");

                entity.Property(e => e.FromDt)
                    .HasColumnType("date")
                    .HasColumnName("fromDt");

                entity.Property(e => e.Gpa)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("GPA");

                entity.Property(e => e.ProfileId).HasColumnName("profileId");

                entity.Property(e => e.SchoolName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("schoolName");

                entity.Property(e => e.ToDt)
                    .HasColumnType("date")
                    .HasColumnName("toDt");

                entity.HasOne(d => d.Profile)
                    .WithMany(p => p.Educations)
                    .HasForeignKey(d => d.ProfileId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_education_profile");
            });

            modelBuilder.Entity<email>(entity =>
            {
                entity.ToTable("email");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Email1)
                    .IsRequired()
                    .HasColumnName("email");

                entity.Property(e => e.ProfileId).HasColumnName("profileId");

                entity.HasOne(d => d.Profile)
                    .WithMany(p => p.Emails)
                    .HasForeignKey(d => d.ProfileId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_email_profile");
            });

            modelBuilder.Entity<Experience>(entity =>
            {
                entity.ToTable("experience");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnName("description");

                entity.Property(e => e.Employer)
                    .IsRequired()
                    .HasColumnName("employer");

                entity.Property(e => e.FromDt)
                    .HasColumnType("datetime")
                    .HasColumnName("fromDt");

                entity.Property(e => e.ProfileId).HasColumnName("profileId");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasColumnName("title");

                entity.Property(e => e.ToDt)
                    .HasColumnType("datetime")
                    .HasColumnName("toDt");

                entity.HasOne(d => d.Profile)
                    .WithMany(p => p.Experiences)
                    .HasForeignKey(d => d.ProfileId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_experience_profile");
            });

            modelBuilder.Entity<Language>(entity =>
            {
                entity.ToTable("languages");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.LangName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("langName");

                entity.Property(e => e.ProfileId).HasColumnName("profileId");

                entity.HasOne(d => d.Profile)
                    .WithMany(p => p.Languages)
                    .HasForeignKey(d => d.ProfileId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_languages_profile");
            });

            modelBuilder.Entity<Link>(entity =>
            {
                entity.ToTable("Links");
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.FacebookUrl).HasColumnName("FacebookURL");

                entity.Property(e => e.GithubUrl).HasColumnName("GithubURL");

                entity.Property(e => e.LinkedInUrl).HasColumnName("LinkedInURL");

                entity.Property(e => e.ProfileId).HasColumnName("profileId");

                entity.Property(e => e.TwitterUrl).HasColumnName("TwitterURL");

                entity.HasOne(d => d.Profile)
                    .WithMany(p => p.Links)
                    .HasForeignKey(d => d.ProfileId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Links_profile");
            });

            modelBuilder.Entity<Phone>(entity =>
            {
                entity.ToTable("phone");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Phone1)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnName("phone")
                    .IsFixedLength(true);

                entity.Property(e => e.ProfileId).HasColumnName("profileId");

                entity.HasOne(d => d.Profile)
                    .WithMany(p => p.Phones)
                    .HasForeignKey(d => d.ProfileId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_phone_profile");
            });

            modelBuilder.Entity<Profile>(entity =>
            {
                entity.ToTable("profile");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.About).HasColumnName("about");

                entity.Property(e => e.Address)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("address");

                entity.Property(e => e.Address2)
                    .HasMaxLength(50)
                    .HasColumnName("address2");

                entity.Property(e => e.City)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("city");

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("firstName");

                entity.Property(e => e.Interests).HasColumnName("interests");

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("lastName");

                entity.Property(e => e.MidName)
                    .HasMaxLength(50)
                    .HasColumnName("midName");

                entity.Property(e => e.PicUrl)
                    .HasMaxLength(200)
                    .HasColumnName("picURL");

                entity.Property(e => e.State)
                    .IsRequired()
                    .HasMaxLength(2)
                    .HasColumnName("state")
                    .IsFixedLength(true);

                entity.Property(e => e.UserId).HasColumnName("userId");

                entity.Property(e => e.Zip)
                    .IsRequired()
                    .HasMaxLength(5)
                    .HasColumnName("zip")
                    .IsFixedLength(true);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Profiles)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_profile_user");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.ToTable("users");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("userName");
            });

            modelBuilder.Entity<Workflow>(entity =>
            {
                entity.ToTable("workflows");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.ProfileId).HasColumnName("profileId");

                entity.Property(e => e.WorkFlow1)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("workFlow");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
