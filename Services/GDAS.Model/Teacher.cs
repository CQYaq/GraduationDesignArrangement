using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GDAS.Model
{
    public class Teacher : BaseModel
    {
        public string WorkNumber { get; set; } // 工号
        public string Name { get; set; } // 姓名
        public string Title { get; set; } // 职称
        public string College { get; set; } // 所属院系
    }
}