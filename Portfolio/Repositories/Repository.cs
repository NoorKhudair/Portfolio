using Microsoft.EntityFrameworkCore;
using Portfolio.Data;
using Portfolio.Models;

namespace Portfolio.Repositories
{
    public class Repository<T> : IRepository<T> where T : BaseEntity
    {
        DataDbContext dbContext;
        DbSet<T> dbSet;
        public Repository(DataDbContext dbContext)
        {this.dbContext = dbContext;
        dbSet = dbContext.Set<T>();

        }


        public void Add(T entity)
        {
            entity.CreatedAt = DateTime.Now;
            dbSet.Add(entity);
            dbContext.SaveChanges();
        }

        public void changeStatus(T entity)
        {
            entity.IsActive = !entity.IsActive;
            dbSet.Update(entity);
            dbContext.SaveChanges();
        }

        public void Delete(T entity)
        {
            dbSet.Remove(entity);
            dbContext.SaveChanges();
        }

        public List<T> GetAll()
        {
            return dbSet.Where(x => !x.IsDeleted).ToList();
        }

        public List<T> GetAllClient()
        {
            return dbSet.Where(x => !x.IsDeleted && x.IsActive).ToList();
        }

        public T GetById(int id)
        {
            return dbSet.FirstOrDefault(x => x.Id == id && !x.IsDeleted);
        }

        public void Update(T entity)
        {
            entity.EditedAt = DateTime.Now;

            dbSet.Update(entity);
            dbContext.SaveChanges();
        }
    }
}
