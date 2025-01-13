using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GDAS.Model
{
    public class DefensePlan:BaseModel
    {
        public string Name { get; set; } // 答辩计划名称
        public string? CreateDate { get; set; }//计划创建时间
        public string Status { get; set; } // 状态（如：待审核、已发布等）

        //导航属性
        public ICollection<DefenseGroup> DefenseGroups { get; set; }
    }
}