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
    // AccountLoginRelation
    public partial class AccountLoginRelation
    {
        public string LoginProvider { get; set; } // LoginProvider (Primary key)
        public string ProviderKey { get; set; } // ProviderKey (Primary key)
        public int UserId { get; set; } // UserId (Primary key)

        // Foreign keys
        public virtual Accounts Accounts { get; set; } // FK_dbo.AccountLoginRelation_dbo.Accounts_UserId
        
        public AccountLoginRelation()
        {
            InitializePartial();
        }

        partial void InitializePartial();
    }

}
// </auto-generated>
