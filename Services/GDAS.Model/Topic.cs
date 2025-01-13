using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GDAS.Model
{
    /// <summary>
    /// 学生选题表
    /// </summary>
    public class Topic:BaseModel
    {
        public string StudentNumber { get; set; } // 学生学号
        public string TeacherWorkNumber { get; set; } // 教师工号
        public string CourseName { get; set; } // 课题名称

        // 导航属性
        public Student? Student { get; set; } // 关联的学生实体
        public Teacher? Teacher { get; set; } // 关联的教师实体
    }
}