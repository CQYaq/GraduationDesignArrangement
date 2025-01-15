using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using GDAS.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace GDAS.ef.Repository
{
   public class EntityRepository<T> where T : BaseModel, new()
    {

        private static readonly EntityRepository<T> m_BookService = new EntityRepository<T>();
        private DbContext Ctx
        {
            get
            {
                return new GDASDbContent();
            }
        }

        public static EntityRepository<T> Instance
        {
            get { return m_BookService; }
        }
        //AsNoTracking() AsNoTracking 方法用于指示 EF Core 在执行查询时不要跟踪返回的实体
        public async Task<IEnumerable<T>> GetAll()
        {
            using (var db = this.Ctx)
            {
                return await db.Set<T>().AsNoTracking().ToArrayAsync();
            }
        }

        public async Task<T> GetByID(int id)
        {
            using (var db = this.Ctx)
            {
                return await db.Set<T>().AsNoTracking().FirstOrDefaultAsync(c => c.Id == id);
            }
        }
        /// <summary>
        /// 根据条件查询
        /// </summary>
        /// <param name="whereLambda"></param>
        /// <returns></returns>
        public async Task<IEnumerable<T>> GetWhere(Expression<Func<T, bool>> whereLambda)
        {
            using (var db = this.Ctx)
            {
                return await db.Set<T>().Where(whereLambda).AsNoTracking().ToArrayAsync();
            }
        }
        public async Task<T> Get(Expression<Func<T, bool>> whereLambda)
        {
            using (var db = this.Ctx)
            {
                return await db.Set<T>().Where(whereLambda).AsNoTracking().FirstOrDefaultAsync();
            }
        }
        public bool Delete(int id)
        {
            using (var db = this.Ctx)
            {
                var item = db.Set<T>().Find(id);
                if (item != null)
                {
                    db.Set<T>().Remove(item);
                    db.SaveChanges();
                }

                return true;
            }
        }

        public async Task<bool> InsertAsync(T model)
        {
            using (var db = this.Ctx)
            {
                model.Id = 0;

                await db.Set<T>().AddAsync(model);
                await db.SaveChangesAsync();
                return true;
            }
        }
        /// <summary>
        /// 新增后返回实体
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public async Task<T?> InsertModelAsync(T model)
        {
            using (var db = this.Ctx)
            {
                model.Id = 0;
                await db.Set<T>().AddAsync(model);
                await db.SaveChangesAsync();
                return await db.Set<T>().FindAsync(model.Id);
            }
        }
        public async Task<bool> InsertAsync(IEnumerable<T> modelLst)
        {
            using (var db = this.Ctx)
            {
                await db.Set<T>().AddRangeAsync(modelLst);
                await db.SaveChangesAsync();

                return true;
            }
        }


        public bool Update(T model, params string[] propertyNames)
        {
            using (var db = this.Ctx)
            {
                // 假设T有一个名为Id的属性用于识别实体  
                var item = db.Set<T>().Find(model.Id); // 使用Find更高效  
                if (item != null)
                {
                    // 3.1.1 将对象添加到EF中以便追踪其变化  
                    EntityEntry entry = db.Entry(item); // 应该使用从数据库检索到的实体，而不是传入的model  
                                                        // 3.1.2 设置对象的状态为Modified，以表示我们将要更新它  
                    entry.State = EntityState.Modified;
                    // 3.1.3 循环被修改的属性名数组  
                    foreach (string propertyName in propertyNames)
                    {
                        // 标记特定属性为已修改，以便EF知道在生成UPDATE语句时需要包括这些属性  
                        entry.Property(propertyName).IsModified = true;
                        // 将model中的新属性值复制到从数据库检索到的实体中  
                        entry.CurrentValues[propertyName] = typeof(T).GetProperty(propertyName).GetValue(model);
                    }
                    db.SaveChanges();
                    return true;
                }

                return false;
            }
        }
    }

}