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
    // ADL100
    public partial class Adl100Configuration : EntityTypeConfiguration<Adl100>
    {
        public Adl100Configuration()
            : this("dbo")
        {
        }
 
        public Adl100Configuration(string schema)
        {
            ToTable(schema + ".ADL100");
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName("Id").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.Name).HasColumnName("Name").IsOptional().HasColumnType("nvarchar").HasMaxLength(30);
            Property(x => x.CurrentTotalElectric).HasColumnName("Current_Total_Electric").IsOptional().HasColumnType("decimal");
            Property(x => x.CurrentPeakElectricEnergy).HasColumnName("Current_peak_electric_energy").IsOptional().HasColumnType("decimal").HasPrecision(18,2);
            Property(x => x.CurrentFloatElectricEnergy).HasColumnName("Current_float_electric_energy").IsOptional().HasColumnType("decimal").HasPrecision(18,2);
            Property(x => x.CurrentValleyElectricEnergy).HasColumnName("Current_valley_electric_energy").IsOptional().HasColumnType("decimal").HasPrecision(18,2);
            Property(x => x.RecordTime).HasColumnName("RecordTime").IsOptional().HasColumnType("datetime");
            Property(x => x.Communication).HasColumnName("Communication").IsOptional().HasColumnType("nvarchar").HasMaxLength(30);
            Property(x => x.CommunicationBaudrate).HasColumnName("CommunicationBaudrate").IsOptional().HasColumnType("int");
            Property(x => x.MonthTotalEnergy).HasColumnName("MonthTotalEnergy").IsOptional().HasColumnType("decimal").HasPrecision(18,2);
            Property(x => x.PeakMonthTotalEnergy).HasColumnName("PeakMonthTotalEnergy").IsOptional().HasColumnType("decimal").HasPrecision(18,2);
            Property(x => x.FlatMonthTotalEnergy).HasColumnName("FlatMonthTotalEnergy").IsOptional().HasColumnType("decimal").HasPrecision(18,2);
            Property(x => x.VolleyMonthTotalEnergy).HasColumnName("VolleyMonthTotalEnergy").IsOptional().HasColumnType("decimal").HasPrecision(18,2);
            Property(x => x.LastMonthTotalEnergy).HasColumnName("LastMonthTotalEnergy").IsOptional().HasColumnType("decimal").HasPrecision(18,2);
            Property(x => x.PeakLastMonthTotalEnergy).HasColumnName("PeakLastMonthTotalEnergy").IsOptional().HasColumnType("decimal").HasPrecision(18,2);
            Property(x => x.FlatLastMonthTotalEnergy).HasColumnName("FlatLastMonthTotalEnergy").IsOptional().HasColumnType("decimal").HasPrecision(18,2);
            Property(x => x.ValleyLastMonthTotalEnergy).HasColumnName("ValleyLastMonthTotalEnergy").IsOptional().HasColumnType("decimal").HasPrecision(18,2);
            Property(x => x.ReversingElectricEnergy).HasColumnName("Reversing_electric_energy").IsOptional().HasColumnType("decimal").HasPrecision(18,2);
            Property(x => x.ReactiveElectricEnergy).HasColumnName("Reactive_electric_energy").IsOptional().HasColumnType("decimal").HasPrecision(18,2);
            Property(x => x.Voltage).HasColumnName("Voltage").IsOptional().HasColumnType("int");
            Property(x => x.Current).HasColumnName("Current").IsOptional().HasColumnType("int");
            Property(x => x.ActivePower).HasColumnName("ActivePower").IsOptional().HasColumnType("int");
            Property(x => x.ReactivePower).HasColumnName("ReactivePower").IsOptional().HasColumnType("int");
            Property(x => x.PowerFactor).HasColumnName("PowerFactor").IsOptional().HasColumnType("int");
            Property(x => x.Frequency).HasColumnName("Frequency").IsOptional().HasColumnType("int");
            InitializePartial();
        }
        partial void InitializePartial();
    }

}
// </auto-generated>