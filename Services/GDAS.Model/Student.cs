using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GDAS.Model
{
    public class Student:BaseModel
    {
        public string StudentNumber { get; set; } // 学号
        public string Name { get; set; } // 姓名
        public string Class { get; set; } // 班级
    }
}