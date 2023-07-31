using Course.Data;
using Course.Entity;
using Microsoft.EntityFrameworkCore;

namespace Course.Services
{
    public class LearningServices : ILearning
    {
        private readonly AppDbContext dbContext;

        public LearningServices(AppDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public Task<Learning> CreateCourse(Learning newLearning)
        {
          dbContext.Courses.Add(newLearning);
          dbContext.SaveChanges();
          return Task.FromResult(newLearning);
        }

        public void DeleteCourse(Guid id)
        {
            var request = dbContext.Courses.FirstOrDefault(c => c.Id == id);
            dbContext.Courses.Remove(request);
            dbContext.SaveChanges();
        }

        public Task<Learning> Get(Guid id)
        {
            var request = dbContext.Courses.FirstOrDefault(c => c.Id == id);
            return Task.FromResult(request);
        }

        public Task<List<Learning>> Gets() => dbContext.Courses.ToListAsync();
       
        public Task<Learning> UpdateCourse(Learning learning)
        {
           dbContext.Courses.Update(learning); 
            dbContext.SaveChanges();
            return Task.FromResult(learning);
        }
    }
}
