using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;

namespace CodeFirstApproach
{
    public class EBContext :DbContext
    {
        public EBContext(): base("Name = EBConnectionstring") {
        }
        public DbSet<ElectricityBillModel> ElectricityBillModel { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //modelBuilder.HasDefaultSchema("EB");
            //modelBuilder.Entity<ElectricityBillModel>().ToTable("EBBillDetails");
            //modelBuilder.Entity<ElectricityBillModel>().HasKey(p => p.CustomerId);
            //modelBuilder.Entity<ElectricityBillModel>().Property(p => p.CustomerId).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            //modelBuilder.Entity<ElectricityBillModel>().Property(property => property.Location).IsRequired();
            //modelBuilder.Entity<ElectricityBillModel>().Property(p => p.BillAmount).HasColumnName("Bill Amount");
            //modelBuilder.Entity<ElectricityBillModel>().Property(p => p.BillAmount).HasColumnOrder(2).IsOptional();

            modelBuilder.Entity<ElectricityBillModel>()
            .MapToStoredProcedures();


            //modelBuilder.Entity<ElectricityBillModel>()
            //.MapToStoredProcedures(p => p.Insert(sp => sp.HasName("sp_InsertEBBill").Parameter(pm => pm.CustomerId, "id"))
            //        .Update(sp => sp.HasName("sp_UpdateEBbill").Parameter(pm => pm.CustomerId, "name"))
            //        .Delete(sp => sp.HasName("sp_DeleteEbbill").Parameter(pm => pm.CustomerId, "Id")));
        }
    }
}
