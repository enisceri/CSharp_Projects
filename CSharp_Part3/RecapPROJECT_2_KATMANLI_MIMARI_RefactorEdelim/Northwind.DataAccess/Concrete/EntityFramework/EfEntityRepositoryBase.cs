﻿using Northwind.DataAccess.Abstract;
using Northwind.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.DataAccess.Concrete.EntityFramework
{
    public class EfEntityRepositoryBase<TEntity, TContext> : IEntityRepository<TEntity>
        where TEntity : class, IEntity, new()
        where TContext : DbContext, new()
    {
        public void AddProduct(TEntity entity)
        {
            using(TContext context = new TContext())
            {
                var addedEntity = context.Entry(entity);
                addedEntity.State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public void DeleteProduct(TEntity entity)
        {
            using(TContext context = new TContext())
            {
                var deletedEntity = context.Entry(entity);
                deletedEntity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public List<TEntity> GetAll(Expression<Func<TEntity, bool>> filter = null)
        {
            using(TContext context = new TContext())
            {
                return filter == null ? context.Set<TEntity>().ToList() :             //Filtre yoksa bu 
                                        context.Set<TEntity>().Where(filter).ToList();//Filtre varsa bu
                //Eskiden su sekilde return ediyorduk:
                // return context.Products.ToList();
                //Simdi illa Products olmak zorunda degil GENERIC olarak calisiyoruz. Bize verilen context ve verilen 
                //entity'e set olup ona ToList() metodunu uyguluyoruz.
            }

        }

        public TEntity GetProduct(Expression<Func<TEntity, bool>> filter)
        {
            using(TContext context = new TContext())
            {
                return context.Set<TEntity>().SingleOrDefault(filter);
            }
        }

        public void UpdateProduct(TEntity entity)
        {
            using(TContext context = new TContext())
            {
                var updatedEntity = context.Entry(entity);
                updatedEntity.State = EntityState.Modified;
                context.SaveChanges();
            }
        }
    }
}
