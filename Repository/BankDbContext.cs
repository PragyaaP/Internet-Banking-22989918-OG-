using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Internet_Banking_22989918.Repository.Models;

namespace Internet_Banking_22989918.Repository
{
    public partial class BankDbContext : DbContext
    {
        public BankDbContext()
        {
        }

        public BankDbContext(DbContextOptions<BankDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AddingBeneficiaryDetail> AddingBeneficiaryDetails { get; set; } = null!;
        public virtual DbSet<Admin> Admins { get; set; } = null!;
        public virtual DbSet<Branch> Branches { get; set; } = null!;
        public virtual DbSet<BranchManagerDetail> BranchManagerDetails { get; set; } = null!;
        public virtual DbSet<BranchManagerLoginDetail> BranchManagerLoginDetails { get; set; } = null!;
        public virtual DbSet<CustomerAccountDetail> CustomerAccountDetails { get; set; } = null!;
        public virtual DbSet<CustomerLoginDetail> CustomerLoginDetails { get; set; } = null!;
        public virtual DbSet<CustomerTransactionDetail> CustomerTransactionDetails { get; set; } = null!;
        public virtual DbSet<InternetBankingRequest> InternetBankingRequests { get; set; } = null!;
        public virtual DbSet<NeftfundTransfer> NeftfundTransfers { get; set; } = null!;
        public virtual DbSet<Registration> Registrations { get; set; } = null!;
        public virtual DbSet<Transaction> Transactions { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=DESKTOP-4CA0P7I\\SQLEXPRESS;Initial Catalog=Bank;Integrated Security=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Branch>(entity =>
            {
                entity.Property(e => e.Bid).IsFixedLength();
            });

            modelBuilder.Entity<BranchManagerDetail>(entity =>
            {
                entity.HasKey(e => e.Bmid)
                    .HasName("PK_BranchManagerDetails_1");

                entity.Property(e => e.Bid).IsFixedLength();

                entity.HasOne(d => d.BidNavigation)
                    .WithMany(p => p.BranchManagerDetails)
                    .HasForeignKey(d => d.Bid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BranchManagerDetails_Branch");
            });

            modelBuilder.Entity<BranchManagerLoginDetail>(entity =>
            {
                entity.HasKey(e => e.Bmname)
                    .HasName("PK_BranchManagerDetails");
            });

            modelBuilder.Entity<CustomerAccountDetail>(entity =>
            {
                entity.Property(e => e.BranchCode).IsFixedLength();
            });

            modelBuilder.Entity<InternetBankingRequest>(entity =>
            {
                entity.Property(e => e.RequestId).IsFixedLength();
            });

            modelBuilder.Entity<Registration>(entity =>
            {
                entity.Property(e => e.BranchCode).IsFixedLength();

                entity.Property(e => e.RequestId).IsFixedLength();
            });

            modelBuilder.Entity<Transaction>(entity =>
            {
                entity.HasOne(d => d.Login)
                    .WithMany()
                    .HasForeignKey(d => d.LoginId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Transaction_CustomerLoginDetails");

                entity.HasOne(d => d.ReceiverSbaccountNumberNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.ReceiverSbaccountNumber)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Transaction_CustomerTransactionDetails");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
