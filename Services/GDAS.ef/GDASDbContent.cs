using GDAS.Model;
using GDAS.Model.Permissions;
using Microsoft.EntityFrameworkCore;

namespace GDAS.ef;

public class GDASDbContent:DbContext
{
    public GDASDbContent(){}

    #region 权限管理类
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
    public DbSet<StudentAssignment> StudentAssignment{get;set;}
    #endregion
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        #region 权限部分
        modelBuilder.Entity<UserInfo>(entity=>{
            entity.HasOne(c => c.RoleInfo).WithMany(c => c.UserInfos).HasForeignKey(c=>c.RoleId);
        });
        modelBuilder.Entity<RoleInfo>(entity=>{
            
        });
        modelBuilder.Entity<MenuInfo>(entity=>{
           
        });
        modelBuilder.Entity<Role_Menu>(entity => {
            entity.HasOne(c=>c.RoleInfo).WithMany(c=>c.Role_Menus).HasForeignKey(c=>c.RoleId);
            entity.HasOne(c => c.MenuInfo).WithMany(c => c.Role_Menus).HasForeignKey(c => c.MenuId);
        });
        #endregion
        #region 主要部分
        modelBuilder.Entity<Student>(entity => {
            
        });
        modelBuilder.Entity<Teacher>(entity => {

        });
        modelBuilder.Entity<Topic>(entity => {

        });
        modelBuilder.Entity<Major>(entity => {

        });
        modelBuilder.Entity<DefensePlan>(entity => {

        });
        modelBuilder.Entity<DefenseGroup>(entity => {
            entity.HasOne(c => c.DefensePlan).WithMany(c => c.DefenseGroups).HasForeignKey(c => c.DefensePlanId);
        });
        modelBuilder.Entity<StudentAssignment>(entity => {
            
        });
        base.OnModelCreating(modelBuilder);
        #endregion
    }

}
