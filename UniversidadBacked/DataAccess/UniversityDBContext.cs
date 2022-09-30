using Microsoft.EntityFrameworkCore;
using UniversidadBacked.Models.DataModels;

namespace UniversidadBacked.DataAccess
{
    public class UniversityDBContext: DbContext
    {
        public UniversityDBContext(DbContextOptions<UniversityDBContext> options): base(options)
        {
           
        }
        //TODO --> add DbSets (tables of our database)
        public DbSet<User>? Users { get; set; }
        public DbSet<Course>? Courses   { get; set; }
    }
}
