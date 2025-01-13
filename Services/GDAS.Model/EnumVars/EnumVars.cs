using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace GDAS.Model.EnumVars
{
    public enum Status
    {
         [Description("禁用")]
        Disabled = 0 ,
        [Description("启用")]
        Enabled = 1,
    }
}