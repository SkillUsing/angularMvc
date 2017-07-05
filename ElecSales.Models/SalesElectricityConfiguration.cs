// <auto-generated>
// ReSharper disable RedundantUsingDirective
// ReSharper disable DoNotCallOverridableMethodsInConstructor
// ReSharper disable InconsistentNaming
// ReSharper disable PartialTypeWithSinglePart
// ReSharper disable PartialMethodWithSinglePart
// ReSharper disable RedundantNameQualifier
// TargetFrameworkVersion = 4.51
#pragma warning disable 1591    //  Ignore "Missing XML Comment" warning

using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Data;
using System.Data.Entity.Core.Objects;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Data.Entity.ModelConfiguration;
using System.Threading;
using DatabaseGeneratedOption = System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption;

namespace ElecSales.Models
{
    // SalesElectricity
    public partial class SalesElectricityConfiguration : EntityTypeConfiguration<SalesElectricity>
    {
        public SalesElectricityConfiguration()
            : this("dbo")
        {
        }
 
        public SalesElectricityConfiguration(string schema)
        {
            ToTable(schema + ".SalesElectricity");
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName("Id").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.Code).HasColumnName("Code").IsRequired().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.Type).HasColumnName("Type").IsRequired().HasColumnType("int");
            Property(x => x.EnterPriseId).HasColumnName("EnterPriseId").IsRequired().HasColumnType("int");
            Property(x => x.ElectricityQuantity).HasColumnName("ElectricityQuantity").IsRequired().HasColumnType("float");
            Property(x => x.Price).HasColumnName("Price").IsRequired().HasColumnType("float");
            Property(x => x.Deviation).HasColumnName("Deviation").IsRequired().HasColumnType("int");
            Property(x => x.StartCycle).HasColumnName("StartCycle").IsRequired().HasColumnType("datetime");
            Property(x => x.EndCycle).HasColumnName("EndCycle").IsRequired().HasColumnType("datetime");
            Property(x => x.ContractContent).HasColumnName("ContractContent").IsRequired().HasColumnType("nvarchar");
            Property(x => x.SaleContractState).HasColumnName("SaleContractState").IsRequired().HasColumnType("int");
            Property(x => x.CreateTime).HasColumnName("CreateTime").IsRequired().HasColumnType("datetime");
            Property(x => x.CreateId).HasColumnName("CreateId").IsRequired().HasColumnType("int");
            Property(x => x.CycleItemJson).HasColumnName("CycleItemJson").IsOptional().IsUnicode(false).HasColumnType("text").HasMaxLength(2147483647);
            Property(x => x.ProjectId).HasColumnName("ProjectId").IsRequired().HasColumnType("int");
            Property(x => x.IsDelete).HasColumnName("IsDelete").IsRequired().HasColumnType("bit");
            InitializePartial();
        }
        partial void InitializePartial();
    }

}
// </auto-generated>
