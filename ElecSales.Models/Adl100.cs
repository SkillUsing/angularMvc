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
    public partial class Adl100
    {
        public int Id { get; set; } // Id (Primary key)
        public string Name { get; set; } // Name
        public decimal? CurrentTotalElectric { get; set; } // Current_Total_Electric
        public decimal? CurrentPeakElectricEnergy { get; set; } // Current_peak_electric_energy
        public decimal? CurrentFloatElectricEnergy { get; set; } // Current_float_electric_energy
        public decimal? CurrentValleyElectricEnergy { get; set; } // Current_valley_electric_energy
        public DateTime? RecordTime { get; set; } // RecordTime
        public string Communication { get; set; } // Communication
        public int? CommunicationBaudrate { get; set; } // CommunicationBaudrate
        public decimal? MonthTotalEnergy { get; set; } // MonthTotalEnergy
        public decimal? PeakMonthTotalEnergy { get; set; } // PeakMonthTotalEnergy
        public decimal? FlatMonthTotalEnergy { get; set; } // FlatMonthTotalEnergy
        public decimal? VolleyMonthTotalEnergy { get; set; } // VolleyMonthTotalEnergy
        public decimal? LastMonthTotalEnergy { get; set; } // LastMonthTotalEnergy
        public decimal? PeakLastMonthTotalEnergy { get; set; } // PeakLastMonthTotalEnergy
        public decimal? FlatLastMonthTotalEnergy { get; set; } // FlatLastMonthTotalEnergy
        public decimal? ValleyLastMonthTotalEnergy { get; set; } // ValleyLastMonthTotalEnergy
        public decimal? ReversingElectricEnergy { get; set; } // Reversing_electric_energy
        public decimal? ReactiveElectricEnergy { get; set; } // Reactive_electric_energy
        public int? Voltage { get; set; } // Voltage
        public int? Current { get; set; } // Current
        public int? ActivePower { get; set; } // ActivePower
        public int? ReactivePower { get; set; } // ReactivePower
        public int? PowerFactor { get; set; } // PowerFactor
        public int? Frequency { get; set; } // Frequency
        
        public Adl100()
        {
            InitializePartial();
        }

        partial void InitializePartial();
    }

}
// </auto-generated>
