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
    // AccountRoles
    public partial class AccountRolesConfiguration : EntityTypeConfiguration<AccountRoles>
    {
        public AccountRolesConfiguration()
            : this("dbo")
        {
        }
 
        public AccountRolesConfiguration(string schema)
        {
            ToTable(schema + ".AccountRoles");
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName("Id").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.Name).HasColumnName("Name").IsRequired().HasColumnType("nvarchar").HasMaxLength(256);
            HasMany(t => t.Accounts).WithMany(t => t.AccountRoles).Map(m => 
            {
                m.ToTable("AccountRoleRelation", "dbo");
                m.MapLeftKey("RoleId");
                m.MapRightKey("UserId");
            });
            InitializePartial();
        }
        partial void InitializePartial();
    }

}
// </auto-generated>
