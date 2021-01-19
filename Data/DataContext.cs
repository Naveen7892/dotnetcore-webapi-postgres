namespace ArticleApp.API.Data { 
    public class DataContext: DbContext {
        public DataContext(DbContextOptions<DataContext> options): base(options) {}
        
        public DbSet<Article> Articles {get; set;}
    }
}