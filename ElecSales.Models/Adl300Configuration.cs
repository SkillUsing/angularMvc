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
    // ADL300
    public partial class Adl300Configuration : EntityTypeConfiguration<Adl300>
    {
        public Adl300Configuration()
            : this("dbo")
        {
        }
 
        public Adl300Configuration(string schema)
        {
            ToTable(schema + ".ADL300");
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName("Id").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.Name).HasColumnName("name").IsOptional().HasColumnType("nvarchar").HasMaxLength(30);
            Property(x => x.CurrentTotalElectric).HasColumnName("Current_Total_Electric").IsOptional().HasColumnType("decimal").HasPrecision(18,2);
            Property(x => x.CurrentPeakElectricEnergy).HasColumnName("Current_peak_electric_energy").IsOptional().HasColumnType("decimal").HasPrecision(18,2);
            Property(x => x.CurrentFloatElectricEnergy).HasColumnName("Current_float_electric_energy").IsOptional().HasColumnType("decimal").HasPrecision(18,2);
            Property(x => x.CurrentValleyElectricEnergy).HasColumnName("Current_valley_electric_energy").IsOptional().HasColumnType("decimal").HasPrecision(18,2);
            Property(x => x.RecordTime).HasColumnName("RecordTime").IsOptional().HasColumnType("datetime");
            Property(x => x.Communication).HasColumnName("Communication").IsOptional().HasColumnType("decimal").HasPrecision(18,2);
            Property(x => x.CommunicationBaudrate).HasColumnName("CommunicationBaudrate").IsOptional().HasColumnType("decimal").HasPrecision(18,2);
            Property(x => x.MonthTotalEnergy).HasColumnName("MonthTotalEnergy").IsOptional().HasColumnType("decimal").HasPrecision(18,2);
            Property(x => x.PeakMonthTotalEnergy).HasColumnName("PeakMonthTotalEnergy").IsOptional().HasColumnType("decimal").HasPrecision(18,2);
            Property(x => x.FlatMonthTotalEnergy).HasColumnName("FlatMonthTotalEnergy").IsOptional().HasColumnType("decimal").HasPrecision(18,2);
            Property(x => x.VolleyMonthTotalEnergy).HasColumnName("VolleyMonthTotalEnergy").IsOptional().HasColumnType("decimal").HasPrecision(18,2);
            Property(x => x.LastMonthTotalEnergy).HasColumnName("LastMonthTotalEnergy").IsOptional().HasColumnType("decimal").HasPrecision(18,2);
            Property(x => x.PeakLastMonthTotalEnergy).HasColumnName("PeakLastMonthTotalEnergy").IsOptional().HasColumnType("decimal").HasPrecision(18,2);
            Property(x => x.FlatLastMonthTotalEnergy).HasColumnName("FlatLastMonthTotalEnergy").IsOptional().HasColumnType("decimal").HasPrecision(18,2);
            Property(x => x.ValleyLastMonthTotalEnergy).HasColumnName("ValleyLastMonthTotalEnergy").IsOptional().HasColumnType("decimal").HasPrecision(18,2);
            Property(x => x.CurrentSpikeElectricEnergy).HasColumnName("CurrentSpikeElectricEnergy").IsOptional().HasColumnType("decimal").HasPrecision(18,2);
            Property(x => x.MonthSpikeEnergy).HasColumnName("MonthSpikeEnergy").IsOptional().HasColumnType("decimal").HasPrecision(18,2);
            Property(x => x.LastMonthSpikeEnergy).HasColumnName("LastMonthSpikeEnergy").IsOptional().HasColumnType("decimal").HasPrecision(18,2);
            InitializePartial();
        }
        partial void InitializePartial();
    }

}
// </auto-generated>
