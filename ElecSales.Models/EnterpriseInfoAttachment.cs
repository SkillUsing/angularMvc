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
    // EnterpriseInfoAttachment
    public partial class EnterpriseInfoAttachment
    {
        public int Id { get; set; } // Id (Primary key)

        ///<summary>
        /// 附件标题
        ///</summary>
        public string Title { get; set; } // Title

        ///<summary>
        /// 企业Id(客户)
        ///</summary>
        public int EnterpriseId { get; set; } // EnterpriseId

        ///<summary>
        /// 附件地址
        ///</summary>
        public string Url { get; set; } // Url

        ///<summary>
        /// 添加人
        ///</summary>
        public int CreateId { get; set; } // CreateId

        ///<summary>
        /// 添加时间
        ///</summary>
        public DateTime CreateTime { get; set; } // CreateTime
        
        public EnterpriseInfoAttachment()
        {
            InitializePartial();
        }

        partial void InitializePartial();
    }

}
// </auto-generated>
