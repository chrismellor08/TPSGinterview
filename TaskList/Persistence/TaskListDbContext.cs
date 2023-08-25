using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using TaskListApp.Entities;

namespace TaskListApp.Persistence
{
    public class TaskListDbContext : DbContext
    {
        public TaskListDbContext(
            DbContextOptions<TaskListDbContext> options
        ) : base(options)
        {

        }

        public DbSet<TaskList> TaskLists { get; set; }
    }
}
