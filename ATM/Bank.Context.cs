//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ATM
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class BankEntities : DbContext
    {
        public BankEntities()
            : base("name=BankEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Member> Member { get; set; }
        public virtual DbSet<Bills> Bills { get; set; }
        public virtual DbSet<TransferInfo> TransferInfo { get; set; }
        public virtual DbSet<Withdraw> Withdraw { get; set; }
        public virtual DbSet<Deposit> Deposit { get; set; }
    }
}
