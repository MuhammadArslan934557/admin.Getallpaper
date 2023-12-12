using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Getallpaper_admin.Models;

public partial class WritingfactorPortalDbContext : DbContext
{
    public WritingfactorPortalDbContext()
    {
    }

    public WritingfactorPortalDbContext(DbContextOptions<WritingfactorPortalDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<AsBlog> AsBlogs { get; set; }

    public virtual DbSet<AsComment> AsComments { get; set; }

    public virtual DbSet<AsFile> AsFiles { get; set; }

    public virtual DbSet<AsLeed> AsLeeds { get; set; }

    public virtual DbSet<AsLoginAttempt> AsLoginAttempts { get; set; }

    public virtual DbSet<AsNote> AsNotes { get; set; }

    public virtual DbSet<AsOrder> AsOrders { get; set; }

    public virtual DbSet<AsOtp> AsOtps { get; set; }

    public virtual DbSet<AsRevision> AsRevisions { get; set; }

    public virtual DbSet<AsSocialLogin> AsSocialLogins { get; set; }

    public virtual DbSet<AsTransaction> AsTransactions { get; set; }

    public virtual DbSet<AsUser> AsUsers { get; set; }

    public virtual DbSet<AsUserDetail> AsUserDetails { get; set; }

    public virtual DbSet<AsUserRole> AsUserRoles { get; set; }

    public virtual DbSet<CampLeed> CampLeeds { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //=> optionsBuilder.UseMySQL("Server=192.236.160.23;Port=3306;Database=writingfactor_portal_db;Uid=writingfactor_portal_usr;Password=Z72dN6bbfAQNUeh4;AllowZeroDateTime=True;Pooling=False;default command timeout =60000");
        => optionsBuilder.UseMySQL("Server=localhost;Database=writingfactor_portal_db;User=root;Password=;ConvertZeroDateTime=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<AsBlog>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("as_blogs");

            entity.Property(e => e.Id).HasColumnType("int(11)");
            entity.Property(e => e.Description)
                .HasDefaultValueSql("'NULL'")
                .HasColumnType("varchar(30000)");
            entity.Property(e => e.PublishedOn)
                .HasMaxLength(100)
                .HasDefaultValueSql("'NULL'");
            entity.Property(e => e.Title)
                .HasMaxLength(255)
                .HasDefaultValueSql("'NULL'");
            entity.Property(e => e.Url)
                .HasMaxLength(150)
                .HasDefaultValueSql("'NULL'");
            entity.Property(e => e.WrittenBy)
                .HasMaxLength(100)
                .HasDefaultValueSql("'NULL'");
        });

        modelBuilder.Entity<AsComment>(entity =>
        {
            entity.HasKey(e => e.CommentId).HasName("PRIMARY");

            entity.ToTable("as_comments");

            entity.Property(e => e.CommentId)
                .HasColumnType("int(11)")
                .HasColumnName("comment_id");
            entity.Property(e => e.Comment)
                .HasColumnType("text")
                .HasColumnName("comment");
            entity.Property(e => e.PostTime)
                .HasColumnType("datetime")
                .HasColumnName("post_time");
            entity.Property(e => e.PostedBy)
                .HasColumnType("int(11)")
                .HasColumnName("posted_by");
            entity.Property(e => e.PostedByName)
                .HasMaxLength(30)
                .HasColumnName("posted_by_name");
        });

        modelBuilder.Entity<AsFile>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("as_files");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.File)
                .HasMaxLength(255)
                .HasDefaultValueSql("'NULL'")
                .HasColumnName("file");
            entity.Property(e => e.FinalFile)
                .HasMaxLength(255)
                .HasDefaultValueSql("'NULL'")
                .HasColumnName("final_file");
            entity.Property(e => e.OrderId)
                .HasColumnType("text")
                .HasColumnName("order_id");
        });

        modelBuilder.Entity<AsLeed>(entity =>
        {
            entity.HasNoKey()
                .ToTable("as_leeds");
            entity.HasKey(e => e.LeedId).HasName("PRIMARY");
            

            entity.Property(e => e.Comment)
                .HasMaxLength(255)
                .HasDefaultValueSql("'NULL'")
                .HasColumnName("comment");
            entity.Property(e => e.CommentBy)
                .HasMaxLength(255)
                .HasDefaultValueSql("'NULL'")
                .HasColumnName("comment_by");
            entity.Property(e => e.Documentype)
                .HasMaxLength(500)
                .HasColumnName("documentype");
            entity.Property(e => e.DueDate)
                .HasMaxLength(255)
                .HasColumnName("due_date");
            entity.Property(e => e.Email)
                .HasMaxLength(500)
                .HasColumnName("email");
            entity.Property(e => e.Hours)
                .HasMaxLength(255)
                .HasColumnName("hours");
            entity.Property(e => e.LeedDate)
                .HasMaxLength(255)
                .HasDefaultValueSql("'NULL'")
                .HasColumnName("leed_date");
            entity.Property(e => e.LeedId)
                .HasColumnType("int(11)")
                .HasColumnName("leed_id");
            entity.Property(e => e.Level)
                .HasMaxLength(500)
                .HasColumnName("level");
            entity.Property(e => e.Pageno)
                .HasMaxLength(500)
                .HasColumnName("pageno");
            entity.Property(e => e.Phone)
                .HasMaxLength(500)
                .HasColumnName("phone");
            entity.Property(e => e.Price)
                .HasMaxLength(250)
                .HasColumnName("price");
            entity.Property(e => e.SellerId)
                .HasColumnType("int(11)")
                .HasColumnName("seller_id");
            entity.Property(e => e.SourceSite)
                .HasMaxLength(200)
                .HasColumnName("source_site");
            entity.Property(e => e.Status)
                .HasMaxLength(255)
                .HasDefaultValueSql("'''New Lead'''")
                .HasColumnName("status");
        });

        modelBuilder.Entity<AsLoginAttempt>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("as_login_attempts");

            entity.Property(e => e.AttemptNumber)
                .HasDefaultValueSql("'1'")
                .HasColumnType("int(11)")
                .HasColumnName("attempt_number");
            entity.Property(e => e.Date)
                .HasColumnType("date")
                .HasColumnName("date");
            entity.Property(e => e.IdLoginAttempts)
                .HasColumnType("int(11)")
                .HasColumnName("id_login_attempts");
            entity.Property(e => e.IpAddr)
                .HasMaxLength(20)
                .HasColumnName("ip_addr");
        });

        modelBuilder.Entity<AsNote>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("as_notes");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.NoteBy)
                .HasMaxLength(255)
                .HasColumnName("note_by");
            entity.Property(e => e.NoteDate)
                .HasColumnType("datetime")
                .HasColumnName("note_date");
            entity.Property(e => e.OrderId)
                .HasMaxLength(255)
                .HasColumnName("order_id");
            entity.Property(e => e.OrderNote)
                .HasColumnType("text")
                .HasColumnName("order_note");
        });

        modelBuilder.Entity<AsOrder>(entity =>
        {
            entity .HasNoKey().ToTable("as_orders");

            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.Property(e => e.Citation)
                .HasMaxLength(255)
                .HasDefaultValueSql("'NULL'")
                .HasColumnName("citation");
            entity.Property(e => e.Closed)
                .HasColumnType("int(11)")
                .HasColumnName("closed");
            entity.Property(e => e.Comment)
                .HasMaxLength(255)
                .HasColumnName("comment");
            entity.Property(e => e.CommentBy)
                .HasMaxLength(255)
                .HasColumnName("comment_by");
            entity.Property(e => e.Description)
                .HasDefaultValueSql("'NULL'")
                .HasColumnType("text")
                .HasColumnName("description");
            entity.Property(e => e.Discount).HasColumnType("int(11)");
            entity.Property(e => e.Email)
                .HasMaxLength(255)
                .HasDefaultValueSql("'NULL'")
                .HasColumnName("email");
            entity.Property(e => e.Hours)
                .HasMaxLength(255)
                .HasDefaultValueSql("'NULL'")
                .HasColumnName("hours");
            entity.Property(e => e.Id)
                .HasColumnType("int(10)")
                .HasColumnName("id");
            entity.Property(e => e.Level)
                .HasMaxLength(255)
                .HasColumnName("level");
            entity.Property(e => e.Note)
                .HasMaxLength(255)
                .HasColumnName("note");
            entity.Property(e => e.NoteBy)
                .HasMaxLength(255)
                .HasColumnName("note_by");
            entity.Property(e => e.OrderDate)
                .HasDefaultValueSql("'NULL'")
                .HasColumnType("datetime")
                .HasColumnName("order_date");
            entity.Property(e => e.OrderId)
                .HasColumnType("text")
                .HasColumnName("order_id");
            entity.Property(e => e.OrderStatus)
                .HasMaxLength(255)
                .HasDefaultValueSql("'''New Order'''")
                .HasColumnName("order_status");
            entity.Property(e => e.OtherCitation)
                .HasMaxLength(255)
                .HasDefaultValueSql("'NULL'")
                .HasColumnName("other_citation");
            entity.Property(e => e.OtherDueDate)
                .HasMaxLength(255)
                .HasDefaultValueSql("'NULL'")
                .HasColumnName("other_due_date");
            entity.Property(e => e.OtherSubject)
                .HasMaxLength(255)
                .HasDefaultValueSql("'NULL'")
                .HasColumnName("other_subject");
            entity.Property(e => e.Pages)
                .HasMaxLength(255)
                .HasColumnName("pages");
            entity.Property(e => e.Payment)
                .HasMaxLength(255)
                .HasDefaultValueSql("'''Unpaid'''")
                .HasColumnName("payment");
            entity.Property(e => e.Phone)
                .HasMaxLength(255)
                .HasDefaultValueSql("'NULL'")
                .HasColumnName("phone");
            entity.Property(e => e.Price)
                .HasColumnType("text")
                .HasColumnName("price");
            entity.Property(e => e.RequiredSource)
                .HasMaxLength(255)
                .HasDefaultValueSql("'NULL'")
                .HasColumnName("required_source");
            entity.Property(e => e.SellerId)
                .HasColumnType("int(11)")
                .HasColumnName("seller_id");
            entity.Property(e => e.SourceSite)
                .HasMaxLength(250)
                .HasDefaultValueSql("'NULL'")
                .HasColumnName("source_site");
            entity.Property(e => e.Status)
                .HasMaxLength(255)
                .HasDefaultValueSql("'''New Lead'''")
                .HasColumnName("status");
            entity.Property(e => e.Subject)
                .HasMaxLength(255)
                .HasDefaultValueSql("'NULL'")
                .HasColumnName("subject");
            entity.Property(e => e.Title)
                .HasMaxLength(255)
                .HasDefaultValueSql("'NULL'")
                .HasColumnName("title");
            entity.Property(e => e.Type)
                .HasMaxLength(255)
                .HasColumnName("type");
            entity.Property(e => e.Verified)
                .HasMaxLength(255)
                .HasColumnName("verified");
            entity.Property(e => e.VerifiedBy)
                .HasMaxLength(255)
                .HasColumnName("verified_by");
            entity.Property(e => e.VerifiedDate)
                .HasDefaultValueSql("'NULL'")
                .HasColumnType("date")
                .HasColumnName("verified_date");
            entity.Property(e => e.WriterDate)
                .HasMaxLength(255)
                .HasColumnName("writer_date");
            entity.Property(e => e.WriterHours)
                .HasMaxLength(255)
                .HasColumnName("writer_hours");
            entity.Property(e => e.WriterId)
                .HasColumnType("int(11)")
                .HasColumnName("writer_id");
        });

        modelBuilder.Entity<AsOtp>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("as_otp");

            entity.Property(e => e.CreatedAt)
                .HasMaxLength(255)
                .HasColumnName("created_at");
            entity.Property(e => e.Email)
                .HasMaxLength(255)
                .HasColumnName("email");
            entity.Property(e => e.Otp)
                .HasMaxLength(100)
                .HasColumnName("otp");
            entity.Property(e => e.OtpId)
                .HasColumnType("int(11)")
                .HasColumnName("otp_id");
        });

        modelBuilder.Entity<AsRevision>(entity =>
        {
            entity.HasNoKey().ToTable("as_revisions");

            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.Property(e => e.Description)
                .HasMaxLength(500)
                .HasColumnName("description");
            entity.Property(e => e.Email)
                .HasMaxLength(500)
                .HasColumnName("email");
            entity.Property(e => e.File)
                .HasMaxLength(500)
                .HasColumnName("file");
            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.Name)
                .HasMaxLength(500)
                .HasColumnName("name");
            entity.Property(e => e.OrderId)
                .HasMaxLength(500)
                .HasColumnName("order_id");
            entity.Property(e => e.Phone)
                .HasMaxLength(500)
                .HasColumnName("phone");
            entity.Property(e => e.RevDate)
                .HasMaxLength(255)
                .HasDefaultValueSql("'NULL'")
                .HasColumnName("rev_date");
            entity.Property(e => e.Revid)
                .HasMaxLength(500)
                .HasColumnName("revid");
            entity.Property(e => e.Verified)
                .HasMaxLength(255)
                .HasColumnName("verified");
            entity.Property(e => e.VerifiedBy)
                .HasMaxLength(255)
                .HasColumnName("verified_by");
            entity.Property(e => e.VerifiedDate)
                .HasColumnType("datetime")
                .HasColumnName("verified_date");
        });

        modelBuilder.Entity<AsSocialLogin>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("as_social_logins");

            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("'NULL'")
                .HasColumnType("datetime")
                .HasColumnName("created_at");
            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.Provider)
                .HasMaxLength(50)
                .HasDefaultValueSql("'''email'''")
                .HasColumnName("provider");
            entity.Property(e => e.ProviderId)
                .HasMaxLength(250)
                .HasDefaultValueSql("'NULL'")
                .HasColumnName("provider_id");
            entity.Property(e => e.UserId)
                .HasColumnType("int(11)")
                .HasColumnName("user_id");
        });

        modelBuilder.Entity<AsTransaction>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("as_transaction");

            entity.Property(e => e.DelStatus)
                .HasDefaultValueSql("'NULL'")
                .HasColumnName("del_status");
            entity.Property(e => e.OrderId)
                .HasMaxLength(200)
                .HasDefaultValueSql("'NULL'")
                .HasColumnName("order_id");
            entity.Property(e => e.PaidAmount)
                .HasMaxLength(20)
                .HasDefaultValueSql("'NULL'")
                .HasColumnName("paid_amount");
            entity.Property(e => e.PaymentStatus)
                .HasMaxLength(50)
                .HasDefaultValueSql("'NULL'")
                .HasColumnName("payment_status");
            entity.Property(e => e.RemainingAmount)
                .HasMaxLength(50)
                .HasDefaultValueSql("'NULL'")
                .HasColumnName("remaining_amount");
            entity.Property(e => e.SourceSite)
                .HasMaxLength(200)
                .HasColumnName("source_site");
            entity.Property(e => e.TotalAmount)
                .HasMaxLength(20)
                .HasDefaultValueSql("'NULL'")
                .HasColumnName("total_amount");
            entity.Property(e => e.TransDate)
                .HasDefaultValueSql("'NULL'")
                .HasColumnType("date")
                .HasColumnName("trans_date");
            entity.Property(e => e.TransId)
                .HasColumnType("int(11)")
                .HasColumnName("trans_id");
            entity.Property(e => e.UserEmail)
                .HasMaxLength(200)
                .HasDefaultValueSql("'NULL'")
                .HasColumnName("user_email");
        });

        modelBuilder.Entity<AsUser>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("as_users");

            entity.Property(e => e.Banned)
                .HasDefaultValueSql("'''N'''")
                .HasColumnType("enum('Y','N')")
                .HasColumnName("banned");
            entity.Property(e => e.ConfirmationKey)
                .HasMaxLength(40)
                .HasColumnName("confirmation_key");
            entity.Property(e => e.Confirmed)
                .HasDefaultValueSql("'''N'''")
                .HasColumnType("enum('Y','N')")
                .HasColumnName("confirmed");
            entity.Property(e => e.Email)
                .HasMaxLength(40)
                .HasColumnName("email");
            entity.Property(e => e.LastLogin)
                .HasDefaultValueSql("'NULL'")
                .HasColumnType("datetime")
                .HasColumnName("last_login");
            entity.Property(e => e.OrderId)
                .HasMaxLength(255)
                .HasColumnName("order_id");
            entity.Property(e => e.Password)
                .HasMaxLength(250)
                .HasColumnName("password");
            entity.Property(e => e.PasswordResetConfirmed)
                .HasDefaultValueSql("'''N'''")
                .HasColumnType("enum('Y','N')")
                .HasColumnName("password_reset_confirmed");
            entity.Property(e => e.PasswordResetKey)
                .HasMaxLength(250)
                .HasDefaultValueSql("''''''")
                .HasColumnName("password_reset_key");
            entity.Property(e => e.PasswordResetTimestamp)
                .HasDefaultValueSql("'NULL'")
                .HasColumnType("datetime")
                .HasColumnName("password_reset_timestamp");
            entity.Property(e => e.Phone)
                .HasMaxLength(250)
                .HasColumnName("phone");
            entity.Property(e => e.ProfileImage)
                .HasMaxLength(100)
                .HasDefaultValueSql("'NULL'")
                .HasColumnName("profile_image");
            entity.Property(e => e.RegisterDate)
                .HasColumnType("date")
                .HasColumnName("register_date");
            entity.Property(e => e.UserId)
                .HasColumnType("int(11)")
                .HasColumnName("user_id");
            entity.Property(e => e.UserRole)
                .HasDefaultValueSql("'1'")
                .HasColumnType("int(4)")
                .HasColumnName("user_role");
            entity.Property(e => e.Username)
                .HasMaxLength(250)
                .HasColumnName("username");
        });

        modelBuilder.Entity<AsUserDetail>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("as_user_details");

            entity.Property(e => e.Address)
                .HasMaxLength(255)
                .HasDefaultValueSql("''''''")
                .HasColumnName("address");
            entity.Property(e => e.FirstName)
                .HasMaxLength(35)
                .HasDefaultValueSql("''''''")
                .HasColumnName("first_name");
            entity.Property(e => e.IdUserDetails)
                .HasColumnType("int(11)")
                .HasColumnName("id_user_details");
            entity.Property(e => e.LastName)
                .HasMaxLength(35)
                .HasDefaultValueSql("''''''")
                .HasColumnName("last_name");
            entity.Property(e => e.UserId)
                .HasColumnType("int(11)")
                .HasColumnName("user_id");
        });

        modelBuilder.Entity<AsUserRole>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("as_user_roles");

            entity.Property(e => e.Role)
                .HasMaxLength(20)
                .HasColumnName("role");
            entity.Property(e => e.RoleId)
                .HasColumnType("int(11)")
                .HasColumnName("role_id");
        });

        modelBuilder.Entity<CampLeed>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("camp_leeds");

            entity.Property(e => e.Contact)
                .HasMaxLength(255)
                .HasDefaultValueSql("'NULL'");
            entity.Property(e => e.Desc)
                .HasDefaultValueSql("'NULL'")
                .HasColumnType("text");
            entity.Property(e => e.Id).HasColumnType("int(11)");
            entity.Property(e => e.Name).HasMaxLength(255);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
