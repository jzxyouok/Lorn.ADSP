//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace Lorn.ADSP.Common.DataModels
{
    using System;
    using System.Collections.Generic;
    
    /// <summary>
    /// 创意类型表单定义
    /// </summary>
    public partial class CreativeTypeFormDefinition
    {
        partial void InitPKDefaultValues();
        public CreativeTypeFormDefinition()
        {
    		InitPKDefaultValues();
            this.ChildCreativeTypeFormDefinitions = new HashSet<CreativeTypeFormDefinition>();
    
    	}
        /// <summary>
        /// CreativeTypeFormDefinitionId
        /// </summary>
        public System.Guid CreativeTypeFormDefinitionId { get; set; }
        /// <summary>
        /// 创意类型表单定义名称
        /// </summary>
        public string CreativeTypeFormDefinitionName { get; set; }
        /// <summary>
        /// 数据类型
        /// </summary>
        public int DataType { get; set; }
        /// <summary>
        /// 最大长度
        /// </summary>
        public Nullable<int> MaxLength { get; set; }
        /// <summary>
        /// 支持最大数量
        /// </summary>
        public Nullable<short> SupportMaxNumber { get; set; }
        /// <summary>
        /// 描述
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// 验证表达式
        /// </summary>
        public string ValidateExpression { get; set; }
        /// <summary>
        /// 显示排序
        /// </summary>
        public Nullable<int> DisplaySort { get; set; }
        /// <summary>
        /// CreativeType_CreativeTypeId
        /// </summary>
        public System.Guid CreativeType_CreativeTypeId { get; set; }
        /// <summary>
        /// MaterialFormat_MaterialFormatId
        /// </summary>
        public System.Guid MaterialFormat_MaterialFormatId { get; set; }
        /// <summary>
        /// 创意类型表单定义代码
        /// </summary>
        public string CreativeTypeFormDefinitionCode { get; set; }
    
         /// <summary>
        /// 创意类型
        /// </summary>
        public virtual CreativeType CreativeType { get; set; }
         /// <summary>
        /// 素材格式
        /// </summary>
        public virtual MaterialFormat MaterialFormat { get; set; }
         /// <summary>
        /// 子表单定义
        /// </summary>
        public virtual ICollection<CreativeTypeFormDefinition> ChildCreativeTypeFormDefinitions { get; set; }
         /// <summary>
        /// 父表单定义
        /// </summary>
        public virtual CreativeTypeFormDefinition ParentCreativeTypeFormDefinition { get; set; }
    }
}
