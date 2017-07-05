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
    // AgentsLog
    public partial class AgentsLogConfiguration : EntityTypeConfiguration<AgentsLog>
    {
        public AgentsLogConfiguration()
            : this("dbo")
        {
        }
 
        public AgentsLogConfiguration(string schema)
        {
            ToTable(schema + ".AgentsLog");
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName("Id").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.Type).HasColumnName("Type").IsRequired().HasColumnType("int");
            Property(x => x.LogContent).HasColumnName("LogContent").IsRequired().HasColumnType("nvarchar").HasMaxLength(200);
            Property(x => x.CreateId).HasColumnName("CreateId").IsRequired().HasColumnType("int");
            Property(x => x.CreateTime).HasColumnName("CreateTime").IsRequired().HasColumnType("datetime");
            Property(x => x.AgentsId).HasColumnName("AgentsId").IsRequired().HasColumnType("int");
            InitializePartial();
        }
        partial void InitializePartial();
    }

}
// </auto-generated>
