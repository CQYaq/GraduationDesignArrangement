using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GDAS.Model.Permissions
{

    public class RoleInfo:BaseModel
    {
        public string Name{get;set;}//角色名称
        public string Level { get; set; }//角色权限等级
        public string Status { get; set; }//角色状态

    }
}