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
    // SalesElectricityCycle
    public partial class SalesElectricityCycleConfiguration : EntityTypeConfiguration<SalesElectricityCycle>
    {
        public SalesElectricityCycleConfiguration()
            : this("dbo")
        {
        }
 
        public SalesElectricityCycleConfiguration(string schema)
        {
            ToTable(schema + ".SalesElectricityCycle");
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName("Id").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.Cycle).HasColumnName("Cycle").IsRequired().HasColumnType("datetime");
            Property(x => x.ElectricityNumber).HasColumnName("ElectricityNumber").IsRequired().HasColumnType("float");
            Property(x => x.SalesElectricityId).HasColumnName("SalesElectricityId").IsRequired().HasColumnType("int");
            InitializePartial();
        }
        partial void InitializePartial();
    }

}
// </auto-generated>
