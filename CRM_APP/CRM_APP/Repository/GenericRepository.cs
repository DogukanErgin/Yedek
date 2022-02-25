using CRM_APP.Context;
using CRM_APP.Models.entities;

namespace CRM_APP.Repository
{
    public class GenericRepository<TEntity> where TEntity : BaseEntityId, new() //şart koyduk class olmalı ve new lenebilir olmalı
    {
        private readonly ApplicationDbContext _context;

        public GenericRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public void Add(TEntity entities)
        {
            using var context = _context;
            context.Set<TEntity>().Add(entities);
            context.SaveChanges();
        }
        public void Update(TEntity entities)
        {

           
           using var context = _context;

            context.Attach<TEntity>(entities).State=Microsoft.EntityFrameworkCore.EntityState.Modified;

          // context.Set<TEntity>().Update(entities);
            context.SaveChanges();
            
        }
        public void Delete(TEntity entities)
        {
            using var context =  _context;
            context.Set<TEntity>().Remove(entities);
            context.SaveChanges();
        }
        public List<TEntity> Get()
        {
            using var context = _context;
            return context.Set<TEntity>().OrderByDescending(I => I.Id).ToList(); 
        }                                                      
        public TEntity GetId(int id)
        {
     
            using var context = _context;

                return context.Set<TEntity>().Find(id);
         

        }
    }
}
