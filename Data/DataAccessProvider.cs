using System.Collections.Generic;
using System.Linq;
using ArticleApp.API.Models;

namespace ArticleApp.API.DataAccess {
    public class DataAccessProvider: IDataAccessProvider {
        private readonly DataContext _context;

        public DataAccessProvider(DataContext context) {
            _context = context;
        }
        public List<Article> GetAllArticles() {
            return _context.Articles.ToList();
        }
    }
}