using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GDAS.Model
{
    public class StudentDefenseGroupAssignment : BaseModel
    {
        public string StudentNumber { get; set; } // 学生学号
        public int DefenseGroupId { get; set; } // 答辩组Id

        // 导航属性
        public Student Student { get; set; } // 关联的学生实体
        public DefenseGroup DefenseGroup { get; set; } // 关联的答辩组实体
    }
}