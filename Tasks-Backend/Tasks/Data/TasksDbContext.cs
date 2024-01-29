using Microsoft.EntityFrameworkCore;
using Tasks.Model;

namespace Tasks.Data
{
    public class TasksDbContext:DbContext
    {
        public TasksDbContext(DbContextOptions<TasksDbContext> options) : base(options)
        {
        }

        public DbSet<TaskM> Tasks { get; set; }
    }
}
