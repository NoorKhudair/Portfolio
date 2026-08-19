using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;
using Portfolio.Models;

namespace Portfolio.Data.Interceptors
{
    public class SoftDeleteInterceptor : SaveChangesInterceptor
    {

        public override InterceptionResult<int> SavingChanges(DbContextEventData eventData, InterceptionResult<int> result)
        {
            var dbContext = eventData.Context;
            if (dbContext is null)
                return new InterceptionResult<int>();

            var models = dbContext.ChangeTracker.Entries<BaseEntity>();
            foreach (var item in models)
            {
                if (item.State == EntityState.Deleted)
                {
                    item.State = EntityState.Modified;
                    item.Entity.IsDeleted = true;

                }
                  
            }

               
            return base.SavingChanges(eventData, result);
        }
    }
}
