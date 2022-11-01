using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfBrandDal : IBrandDal
    {
        public List<Brand> GetAll(Expression<Func<Brand, bool>> filter = null)
        {
            using (CarRentalProjectContext dbContext = new CarRentalProjectContext())
            {
                return filter == null ? dbContext.Set<Brand>().ToList() : dbContext.Set<Brand>().Where(filter).ToList();
            }
        }

        public Brand Get(Expression<Func<Brand, bool>> filter)
        {
            using (CarRentalProjectContext dbContext = new CarRentalProjectContext())
            {
                return dbContext.Set<Brand>().SingleOrDefault();
            }
        }

        public void Add(Brand entity)
        {
            using (CarRentalProjectContext dbContext = new CarRentalProjectContext())
            {
                var addedEntity = dbContext.Entry(entity);
                addedEntity.State = EntityState.Added;
                dbContext.SaveChanges();
            }
        }

        public void Update(Brand entity)
        {
            using (CarRentalProjectContext dbContext = new CarRentalProjectContext())
            {
                var updatedEntity = dbContext.Entry(entity);
                updatedEntity.State = EntityState.Modified;
                dbContext.SaveChanges();
            }
        }

        public void Delete(Brand entity)
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
