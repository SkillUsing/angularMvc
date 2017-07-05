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
    // Agents
    public partial class Agents
    {
        public int Id { get; set; } // Id (Primary key)
        public string Name { get; set; } // Name
        public int EmployeeTotal { get; set; } // EmployeeTotal
        public string Province { get; set; } // Province
        public string City { get; set; } // City
        public DateTime CreateTime { get; set; } // CreateTime
        public string Address { get; set; } // Address
        public string PrincipalName { get; set; } // PrincipalName
        public string Tel { get; set; } // Tel
        public string Remark { get; set; } // Remark
        public int ProjectId { get; set; } // ProjectId
        public int CreateId { get; set; } // CreateId
        public bool IsDelete { get; set; } // IsDelete
        
        public Agents()
        {
            EmployeeTotal = 0;
            CreateTime = System.DateTime.Now;
            ProjectId = 0;
            CreateId = 0;
            IsDelete = false;
            InitializePartial();
        }

        partial void InitializePartial();
    }

}
// </auto-generated>