using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GDAS.Model.GlobalEnumVars
{
    /// <summary>
    /// 全局枚举配置
    /// </summary>
    public class GlobalEnumVars
    {
        public enum Status
        {
            [Description("启用")]
            Enabled = 1,

            [Description("禁用")]
            Disabled=0
        }
    }
}
