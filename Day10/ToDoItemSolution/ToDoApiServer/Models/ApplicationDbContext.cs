using Microsoft.EntityFrameworkCore;

namespace ToDoApiServer.Models
{
    public class ApplicationDbContext : DbContext
    {
        // 생성자를 마법사로 만들것!
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<TodoItem> TodoItems { get; set; }
        
    }
}
