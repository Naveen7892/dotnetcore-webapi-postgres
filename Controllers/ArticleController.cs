using System.Linq;
using ArticleApp.API.DataAccess;
using Microsoft.AspNetCore.Mvc;

namespace ArticleApp.API.Controllers {
    [Route("api/[controller]")]
    [ApiController]
    public class ArticleController: ControllerBase {
        private IDataAccessProvider _dataAccessProvider = null;
        public ArticleController(IDataAccessProvider dataAccessProvider) {
            _dataAccessProvider = dataAccessProvider;
        }

        [HttpGet]
        public ActionResult GetArticles() {
            return Ok(_dataAccessProvider.GetAllArticles());
        }
    }
}