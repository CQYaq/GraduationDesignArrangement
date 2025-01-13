using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GDAS.Model.Permissions
{
    public class MenuInfo:BaseModel
    {

        // 父菜单
        public int? ParentMenuId { get; set; }

        // 菜单名称
        public string MenuName { get; set; }

        // 跳转URL
        public string? Url { get; set; }

        // 图标
        public string? Icon { get; set; }

        // 排序（数值越小，排序越靠前）
        public int? SortOrder { get; set; }

        // 状态（1启用，0禁用）
        public int? Status { get; set; }

        // 子菜单列表
       // public List<MenuInfo>? SubMenus { get; set; } = new List<MenuInfo>();

        public ICollection<Role_Menu>? Role_Menus { get; set; }
    }
}