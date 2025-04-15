using Microsoft.EntityFrameworkCore;
using backend.Models;

namespace backend.Data
{
    public class TaskContext : DbContext
    {
        public TaskContext(DbContextOptions<TaskContext> options) : base(options) { }

        public DbSet<TaskItem> Tasks { get; set; }
    }
}
