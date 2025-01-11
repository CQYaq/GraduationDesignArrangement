using GDAS.Model.Permissions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GDAS.Model
{
    /// <summary>
    /// 学生表
    /// </summary>
    public class Student:BaseModel
    {
        public int?  UserId { get; set; }//用户Id
        public string Grade { get; set; } // 班级

        //导航属性
        public UserInfo UserInfo { get; set; }
    }
}