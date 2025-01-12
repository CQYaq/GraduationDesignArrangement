using GDAS.Model;
using GDAS.Model.Permissions;
using Microsoft.EntityFrameworkCore;

namespace GDAS.ef;

public class GDASDbContent:DbContext
{
    public GDASDbContent(){}

    #region 权限管理表
    public DbSet<UserInfo> UserInfo{get;set;}
    public DbSet<RoleInfo> RoleInfo{get;set;}
     public DbSet<MenuInfo> MenuInfo{get;set;}
    public DbSet<Role_Menu> RoLeMenu{get;set;}
    #endregion
   #region 主要类
    public DbSet<Student> Student{get;set;}
    public DbSet<Teacher> Teacher{get;set;}
    public DbSet<Topic> Topic{get;set;}
    public DbSet<Major> Major{get;set;}
    public DbSet<DefensePlan> DefensePlan{get;set;}
    public DbSet<DefenseGroup> DefenseGroup{get;set;}
    public DbSet<StudentAssignment> studentAssignment{get;set;}
    #endregion
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<UserInfo>(entity=>{
            
        });
        modelBuilder.Entity<RoleInfo>(entity=>{
            
        });
        modelBuilder.Entity<MenuInfo>(entity=>{
            entity.HasOne(c=>c.)
        });       
        
    }

}
