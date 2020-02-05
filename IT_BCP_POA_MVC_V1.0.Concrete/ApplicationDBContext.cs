using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using IT_BCP_POA_MVC_V1._0.Models;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Infrastructure;

namespace IT_BCP_POA_MVC_V1._0.Concrete
{
   public class ApplicationDBContext:DbContext
    {
        public ApplicationDBContext() : base("entityFramework")
        {
        }
        public ApplicationDBContext(string connection)
        {
            this.Database.Connection.ConnectionString = connection;
        }
        public DbSet<Tx_Poa> Poas { get; set; }
        public DbSet<MST_POA_Entity> Entities { get; set; }
        public DbSet<MST_POA_Function> Function { get; set; }
        public DbSet<MST_POA_Powertype> Powertype { get; set; }
        public DbSet<MST_POA_Power> Power { get; set; }
        public DbSet<TX_POA_Appr> approvers { get; set; }
        public DbSet<TX_POA_Power> txtpower { get; set; }
        public DbSet<TX_EMPs> emps { get; set; }
        public DbSet<TX_POA_efpp> ehistory { get; set; }
       protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
        public static ApplicationDBContext Create()
        {
            return new ApplicationDBContext();
        }
        //protected override void OnModelCreating(DbModelBuilder modelBuilder)
        //{
        //    throw new UnintentionalCodeFirstException();
        //}
        //protected override void OnModelCreating(DbModelBuilder modelBuilder)
        //{
        //    modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        //}

    }
}

