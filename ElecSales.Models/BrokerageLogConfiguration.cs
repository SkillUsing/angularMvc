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
    // BrokerageLog
    public partial class BrokerageLogConfiguration : EntityTypeConfiguration<BrokerageLog>
    {
        public BrokerageLogConfiguration()
            : this("dbo")
        {
        }
 
        public BrokerageLogConfiguration(string schema)
        {
            ToTable(schema + ".BrokerageLog");
            HasKey(x => new { x.BrokerageId, x.Type, x.CreateId, x.CreateTime });

            Property(x => x.BrokerageId).HasColumnName("BrokerageId").IsRequired().HasColumnType("int");
            Property(x => x.Type).HasColumnName("Type").IsRequired().HasColumnType("int");
            Property(x => x.LogContent).HasColumnName("LogContent").IsOptional().HasColumnType("nvarchar").HasMaxLength(200);
            Property(x => x.CreateId).HasColumnName("CreateId").IsRequired().HasColumnType("int");
            Property(x => x.CreateTime).HasColumnName("CreateTime").IsRequired().HasColumnType("datetime");
            InitializePartial();
        }
        partial void InitializePartial();
    }

}
// </auto-generated>
