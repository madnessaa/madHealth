using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using madHealth.Database;
using System.Data.Entity;

namespace madHealth.Repository
{
    public class madHealthRepository<Entity>:ImadHealthRepository<Entity> where Entity : class
    {
        protected Context context;
        protected DbSet<Entity> dbSet;

        public madHealthRepository(Context _context)
        {
            context = _context;
            dbSet = context.Set<Entity>();
        }

        public virtual IQueryable<Entity> Get()
        {
            return dbSet;
        }

        public Entity Get(int id)
        {
            return dbSet.Find(id);
        }

        public virtual void Insert(Entity entity)
        {
            dbSet.Add(entity);
        }

        public virtual void Update(Entity entity, int id)
        {
            Entity oldEntity = Get(id);
            if (oldEntity != null)
            {
                context.Entry(oldEntity).CurrentValues.SetValues(entity);
            }
        }

        public void Delete(int id)
        {
            Entity oldEntity = Get(id);
            if (oldEntity != null) dbSet.Remove(oldEntity);
        }

        public bool Commit()
        {
            return (context.SaveChanges() > 0);
        }

        //public void InsertOrUpdate(Entity entity)
        //{
        //    if (entity == default(Entity))
        //    {
        //        dbSet.Add(entity);
        //     }
        //    else
        //    {
        //        context.Entry(entity).State = EntityState.Modified;
        //    }
        //}
    }
}
