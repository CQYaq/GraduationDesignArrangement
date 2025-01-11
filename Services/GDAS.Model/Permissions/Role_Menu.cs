using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GDAS.Model.Permissions
{
    public class Role_Menu:BaseModel
    {
        public int RoleId { get; set; }
        public int MenuId { get; set; }

    }
}