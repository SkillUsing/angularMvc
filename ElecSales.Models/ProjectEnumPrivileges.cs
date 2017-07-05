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
    // ProjectEnumPrivileges
    public partial class ProjectEnumPrivileges
    {
        public int Id { get; set; } // Id (Primary key)

        ///<summary>
        /// 角色Id
        ///</summary>
        public int RoleId { get; set; } // RoleId

        ///<summary>
        /// 菜单Id
        ///</summary>
        public int EnumId { get; set; } // EnumId

        ///<summary>
        /// 权限Id
        ///</summary>
        public int PrivilegesId { get; set; } // PrivilegesId

        ///<summary>
        /// 项目Id
        ///</summary>
        public int ProjectId { get; set; } // ProjectId

        ///<summary>
        /// 是否删除
        ///</summary>
        public bool IsDelete { get; set; } // IsDelete

        ///<summary>
        /// 添加人
        ///</summary>
        public int CreateId { get; set; } // CreateId

        ///<summary>
        /// 添加时间
        ///</summary>
        public DateTime CreateTime { get; set; } // CreateTime
        
        public ProjectEnumPrivileges()
        {
            InitializePartial();
        }

        partial void InitializePartial();
    }

}
// </auto-generated>
