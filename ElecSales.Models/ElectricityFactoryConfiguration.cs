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
    // ElectricityFactory
    public partial class ElectricityFactoryConfiguration : EntityTypeConfiguration<ElectricityFactory>
    {
        public ElectricityFactoryConfiguration()
            : this("dbo")
        {
        }
 
        public ElectricityFactoryConfiguration(string schema)
        {
            ToTable(schema + ".ElectricityFactory");
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName("Id").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.Title).HasColumnName("Title").IsRequired().HasColumnType("nvarchar").HasMaxLength(200);
            Property(x => x.State).HasColumnName("State").IsRequired().HasColumnType("int");
            Property(x => x.CreateId).HasColumnName("CreateId").IsRequired().HasColumnType("int");
            Property(x => x.CreateTime).HasColumnName("CreateTime").IsRequired().HasColumnType("datetime");
            Property(x => x.ProjectId).HasColumnName("ProjectId").IsRequired().HasColumnType("int");
            Property(x => x.Remark).HasColumnName("Remark").IsOptional().HasColumnType("nvarchar").HasMaxLength(140);
            Property(x => x.IsDelete).HasColumnName("IsDelete").IsRequired().HasColumnType("bit");
            Property(x => x.Abbr).HasColumnName("Abbr").IsOptional().HasColumnType("nvarchar").HasMaxLength(20);
            Property(x => x.AddressDetail).HasColumnName("AddressDetail").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.Province).HasColumnName("Province").IsOptional().HasColumnType("nvarchar").HasMaxLength(10);
            Property(x => x.City).HasColumnName("City").IsOptional().HasColumnType("nvarchar").HasMaxLength(10);
            Property(x => x.Tel).HasColumnName("Tel").IsOptional().IsUnicode(false).HasColumnType("varchar").HasMaxLength(20);
            Property(x => x.YearTotal).HasColumnName("YearTotal").IsOptional().HasColumnType("int");
            Property(x => x.EnterpriseCategory).HasColumnName("EnterpriseCategory").IsOptional().HasColumnType("int");
            Property(x => x.Code).HasColumnName("Code").IsOptional().IsUnicode(false).HasColumnType("varchar").HasMaxLength(50);
            Property(x => x.AdministrativeRegion).HasColumnName("AdministrativeRegion").IsOptional().IsUnicode(false).HasColumnType("varchar").HasMaxLength(30);
            Property(x => x.CorpOfCode).HasColumnName("CorpOfCode").IsOptional().IsUnicode(false).HasColumnType("varchar").HasMaxLength(30);
            Property(x => x.CorpOfPerson).HasColumnName("CorpOfPerson").IsOptional().IsUnicode(false).HasColumnType("varchar").HasMaxLength(30);
            Property(x => x.CorpOfIdCard).HasColumnName("CorpOfIdCard").IsOptional().IsUnicode(false).HasColumnType("varchar").HasMaxLength(20);
            Property(x => x.CorpOfTaxCode).HasColumnName("CorpOfTaxCode").IsOptional().IsUnicode(false).HasColumnType("varchar").HasMaxLength(30);
            Property(x => x.AccountBank).HasColumnName("AccountBank").IsOptional().IsUnicode(false).HasColumnType("varchar").HasMaxLength(20);
            Property(x => x.AccountNumber).HasColumnName("AccountNumber").IsOptional().IsUnicode(false).HasColumnType("varchar").HasMaxLength(20);
            InitializePartial();
        }
        partial void InitializePartial();
    }

}
// </auto-generated>
