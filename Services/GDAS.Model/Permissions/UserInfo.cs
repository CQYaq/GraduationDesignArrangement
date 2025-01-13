using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GDAS.Model.Permissions
{
    public class UserInfo:BaseModel
    {
        public string WorkNumber { get; set; } // 工号
        public string? Name { get; set; } // 姓名
        public int RoleId { get; set; }//角色Id
        //导航属性
        public RoleInfo? RoleInfo { get; set; }
    }

}
