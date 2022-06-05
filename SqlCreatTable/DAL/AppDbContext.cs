using Microsoft.EntityFrameworkCore;
using SqlCreatTable.Models;

namespace SqlCreatTable.DAL
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        {

        }

        public DbSet<Slider> Sliders { get; set; }

        public DbSet<Blog> Blogs { get; set; }  
        
        public DbSet<Comment> Comments { get; set; }

        public DbSet<Tag>Tags { get; set; }
    }

    
}
