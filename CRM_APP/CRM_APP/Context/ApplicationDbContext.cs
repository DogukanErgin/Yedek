using CRM_APP.Models.entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace CRM_APP.Context
{
    public class ApplicationDbContext :IdentityDbContext<IdentityUser>
    {

        public DbSet<WorkPlan> WorkPlans { get; set; }
        public DbSet<Company> Companies { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }




        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{

        //    base.OnConfiguring(optionsBuilder); //identity ile eklendi
        //}
    }
}
