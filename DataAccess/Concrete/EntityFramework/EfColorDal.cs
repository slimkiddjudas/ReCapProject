using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Abstract;
using Entities.Abstract;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfColorDal : IColorDal
    {
        public List<Color> GetAll(Expression<Func<Color, bool>> filter = null)
        {
            using (CarRentalProjectContext dbContext = new CarRentalProjectContext())
            {
                return filter == null ? dbContext.Set<Color>().ToList() : dbContext.Set<Color>().Where(filter).ToList();
            }
        }

        public Color Get(Expression<Func<Color, bool>> filter)
        {
            using (CarRentalProjectContext dbContext = new CarRentalProjectContext())
            {
                return dbContext.Set<Color>().SingleOrDefault(filter);
            }
        }

        public void Add(Color entity)
        {
            using (CarRentalProjectContext dbContext = new CarRentalProjectContext())
            {
                var addedEntity = dbContext.Entry(entity);
                addedEntity.State = EntityState.Added;
                dbContext.SaveChanges();
            }
        }

        public void Update(Color entity)
        {
            using (CarRentalProjectContext dbContext = new CarRentalProjectContext())
            {
                var updatedEntity = dbContext.Entry(entity);
                updatedEntity.State = EntityState.Modified;
                dbContext.SaveChanges();
            };
        }

        public void Delete(Color entity)
        {
            using (CarRentalProjectContext dbContext = new CarRentalProjectContext())
            {
                var deletedEntity = dbContext.Entry(entity);
                deletedEntity.State = EntityState.Deleted;
                dbContext.SaveChanges();
            }
        }
    }
}
