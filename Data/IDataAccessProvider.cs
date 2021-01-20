using ArticleApp.API.Models;
using System.Collections.Generic;

namespace ArticleApp.API.DataAccess {
    public interface IDataAccessProvider {
        List<Article> GetAllArticles();
    }    
}
