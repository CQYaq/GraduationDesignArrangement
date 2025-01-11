using GDAS.Model.Permissions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GDAS.Model
{
    /// <summary>
    /// 老师表
    /// </summary>
    public class Teacher : BaseModel
    {
        public int UserId { get; set; }//用户Id
        public string Title { get; set; } // 职称
        public string College { get; set; } // 所属院系

        //导航属性
        public UserInfo UserInfo { get; set; }
    }
}