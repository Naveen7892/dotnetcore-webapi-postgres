using Microsoft.EntityFrameworkCore;
using ArticleApp.API.Models;

namespace ArticleApp.API.DataAccess { 
    public class DataContext: DbContext {
        public DataContext(DbContextOptions<DataContext> options): base(options) {}
        
        public DbSet<Article> Articles {get; set;}

        protected override void OnModelCreating(ModelBuilder builder) {  
            base.OnModelCreating(builder);  
        }  
  
        public override int SaveChanges() {  
            ChangeTracker.DetectChanges();  
            return base.SaveChanges();  
        }  
    }
}