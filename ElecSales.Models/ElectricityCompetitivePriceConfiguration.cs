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
    // ElectricityCompetitivePrice
    public partial class ElectricityCompetitivePriceConfiguration : EntityTypeConfiguration<ElectricityCompetitivePrice>
    {
        public ElectricityCompetitivePriceConfiguration()
            : this("dbo")
        {
        }
 
        public ElectricityCompetitivePriceConfiguration(string schema)
        {
            ToTable(schema + ".ElectricityCompetitivePrice");
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName("Id").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.Title).HasColumnName("Title").IsRequired().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.Content).HasColumnName("Content").IsOptional().HasColumnType("nvarchar");
            Property(x => x.State).HasColumnName("State").IsRequired().HasColumnType("int");
            Property(x => x.CreateId).HasColumnName("CreateId").IsRequired().HasColumnType("int");
            Property(x => x.CreateTime).HasColumnName("CreateTime").IsRequired().HasColumnType("datetime");
            InitializePartial();
        }
        partial void InitializePartial();
    }

}
// </auto-generated>
