using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GDAS.Model
{
    public class DefenseGroup : BaseModel
    {

        public string Name { get; set; } // 答辩组名称
        public string Leader { get; set; } // 组长
        public string Members { get; set; } // 组员（教师工号组用逗号‘,’分割）
        public DateTime DefenseTime { get; set; } // 答辩时间
        public string DefenseLocation { get; set; } // 答辩地点

        // 导航属性（如果使用实体关系）
        // public Teacher LeaderTeacher { get; set; } // 关联的组长教师实体（如果使用工号，则不需要此属性）
        // public List<Teacher> MemberTeachers { get; set; } // 关联的组员教师实体列表（如果使用工号，则不需要此属性）

        // 如果使用工号，并且需要在代码中方便访问教师信息，可以考虑添加以下方法或属性来获取教师实体
        // （注意：这需要在业务逻辑层或数据访问层实现）
        // public Teacher GetLeaderTeacher() { /* 实现获取组长教师实体的逻辑 */ }
        // public List<Teacher> GetMemberTeachers() { /* 实现获取组员教师实体列表的逻辑 */ }
    }
}