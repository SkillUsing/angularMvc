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
    // ADL3000
    public partial class Adl3000
    {
        public int Id { get; set; } // Id (Primary key)
        public string Name { get; set; } // Name
        public decimal? CurrentTotalActiveEnergy { get; set; } // Current_Total_Active_Energy
        public decimal? CurrentTotalSpikeEnergy { get; set; } // Current_Total_Spike_Energy
        public decimal? CurrentTotalActivePeakEnergy { get; set; } // Current_Total_Active_Peak_Energy
        public decimal? CurrentTotalActiveFlatEnergy { get; set; } // Current_Total_Active_Flat_Energy
        public decimal? CurrentTotalActiveValleyEnergy { get; set; } // Current_Total_Active_Valley_Energy
        public decimal? CurrentForwardTotalActiveEnergy { get; set; } // Current_Forward_Total_Active_Energy
        public decimal? CurrentForwardTotalSpikeEnergy { get; set; } // Current_Forward_Total_Spike_Energy
        public decimal? CurrentForwardTotalActivePeakEnergy { get; set; } // Current_Forward_Total_Active_Peak_Energy
        public decimal? CurrentForwardTotalActiveFlatEnergy { get; set; } // Current_Forward_Total_Active_Flat_Energy
        public decimal? CurrentForwardTotalActiveValleyEnergy { get; set; } // Current_Forward_Total_Active_Valley_Energy
        public decimal? CurrentReversingTotalActiveEnergy { get; set; } // Current_Reversing_Total_Active_Energy
        public decimal? CurrentReversingTotalSpikeEnergy { get; set; } // Current_Reversing_Total_Spike_Energy
        public decimal? CurrentReversingTotalActivePeakEnergy { get; set; } // Current_Reversing_Total_Active_Peak_Energy
        public decimal? CurrentReversingTotalActiveFlatEnergy { get; set; } // Current_Reversing_Total_Active_Flat_Energy
        public decimal? CurrentReversingTotalActiveValleyEnergy { get; set; } // Current_Reversing_Total_Active_Valley_Energy
        public decimal? CurrentTotalReactiveEnergy { get; set; } // Current_Total_Reactive_Energy
        public decimal? CurrentTotalReactiveSpikeEnergy { get; set; } // Current_Total_Reactive_Spike_Energy
        public decimal? CurrentTotalReactivePeakEnergy { get; set; } // Current_Total_Reactive_Peak_Energy
        public decimal? CurrentTotalReactiveFlatEnergy { get; set; } // Current_Total_Reactive_Flat_Energy
        public decimal? CurrentTotalReactiveValleyEnergy { get; set; } // Current_Total_Reactive_Valley_Energy
        public decimal? CurrentForwardTotalReactiveEnergy { get; set; } // Current_Forward_Total_Reactive_Energy
        public decimal? CurrentForwardTotalReactiveSpikeEnergy { get; set; } // Current_Forward_Total_Reactive_Spike_Energy
        public decimal? CurrentForwardTotalReactivePeakEnergy { get; set; } // Current_Forward_Total_Reactive_Peak_Energy
        public decimal? CurrentForwardTotalReactiveFlatEnergy { get; set; } // Current_Forward_Total_Reactive_Flat_Energy
        public decimal? CurrentForwardTotalReactiveValleyEnergy { get; set; } // Current_Forward_Total_Reactive_Valley_Energy
        public decimal? CurrentReversingTotalReactiveEnergy { get; set; } // Current_Reversing_Total_Reactive_Energy
        public decimal? CurrentReversingTotalReactiveSpikeEnergy { get; set; } // Current_Reversing_Total_Reactive_Spike_Energy
        public decimal? CurrentReversingTotalReactivePeakEnergy { get; set; } // Current_Reversing_Total_Reactive_Peak_Energy
        public decimal? CurrentReversingTotalReactiveValleyEnergy { get; set; } // Current_Reversing_Total_Reactive_Valley_Energy
        public DateTime? RecordTime { get; set; } // RecordTime
        public string CommunicationAddress { get; set; } // CommunicationAddress
        public string CommunicationBaudrate { get; set; } // CommunicationBaudrate
        public decimal? PulseConstant { get; set; } // PulseConstant
        public decimal? PeriodOfTime { get; set; } // PeriodOfTime
        public decimal? AVoltagePhase { get; set; } // A_voltage_phase
        public decimal? BVoltagePhase { get; set; } // B_voltage_phase
        public decimal? CVoltagePhase { get; set; } // C_voltage_phase
        public decimal? AElectricityPhase { get; set; } // A_electricity_phase
        public decimal? BElectricityPhase { get; set; } // B_electricity_phase
        public decimal? CElectricityPhase { get; set; } // C_electricity_phase
        public decimal? AActivePhase { get; set; } // A_active_phase
        public decimal? BActivePhase { get; set; } // B_active_phase
        public decimal? CActivePhase { get; set; } // C_active_phase
        public decimal? TotalActivePhase { get; set; } // Total_active_phase
        public decimal? AReactivePhase { get; set; } // A_reactive_phase
        public decimal? BReactivePhase { get; set; } // B_reactive_phase
        public decimal? CReactivePhase { get; set; } // C_reactive_phase
        public decimal? TotalReactivePhase { get; set; } // Total_reactive_phase
        public decimal? AApparentPhase { get; set; } // A_apparent_phase
        public decimal? BApparentPhase { get; set; } // B_apparent_phase
        public decimal? CApparentPhase { get; set; } // C_apparent_phase
        public decimal? TotalApparentPhase { get; set; } // Total_apparent_phase
        public decimal? APowerFactorPhase { get; set; } // A_power_factor_phase
        public decimal? CPowerFactorPhase { get; set; } // C_Power_factor_phase
        public decimal? BPowerFactorPhase { get; set; } // B_Power_factor_phase
        public decimal? Frequency { get; set; } // Frequency
        public decimal? StatusIndication { get; set; } // StatusIndication
        public decimal? ActiveMaximumDemand { get; set; } // Active_Maximum_demand
        public decimal? TimeActiviveMaximum { get; set; } // Time_activive_maximum
        public decimal? TimeReactiveMaximum { get; set; } // Time_reactive_maximum
        public decimal? VoltageLostNumber { get; set; } // Voltage_lost_number
        public decimal? TimeVoltageLostNumber { get; set; } // time_voltage_lost_number
        public decimal? CurrentMonthTotalActiveEnergy { get; set; } // Current_month_total_active_energy
        public decimal? CurrentMonthTotalActiveSpikeEnergy { get; set; } // Current_month_total_active_spike_energy
        public decimal? CurrentMonthTotalActiveFlatEnergy { get; set; } // Current_month_total_active_flat_energy
        public decimal? CurrentMonthTotalActiveValleyEnergy { get; set; } // Current_month_total_active_valley_energy
        
        public Adl3000()
        {
            InitializePartial();
        }

        partial void InitializePartial();
    }

}
// </auto-generated>
