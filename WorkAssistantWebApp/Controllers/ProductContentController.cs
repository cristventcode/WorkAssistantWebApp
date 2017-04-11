using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WorkLibrary;

namespace WorkAssistantWebApp.Controllers
{
    public class ProductContentController : ApiController
    {
        public static IWorkRepository _productHandler;


        public ProductContentController()
        {
            if (_productHandler == null)
            {
                _productHandler = new WorkRepoDb();
                //_quizRepo.LoadSampleQuestions();
            }
        }

        public ProductContentController(IWorkRepository newRepo)
        {
            _productHandler = newRepo;
        }


        // GET: api/ProductContent
        public IEnumerable<Product> Get()
        {
            return _productHandler.GetProductAll();
        }

        [Route("api/productcontent/getProductInfo")]
        [HttpGet]
        public List<Product> getProductInfo(string productName)
        {
            return _productHandler.GetProductByName(productName);
        }

        // GET: api/ProductContent/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/ProductContent
        public void Post(int workdayid, [FromBody]string newtask)
        {

        }

        // PUT: api/ProductContent/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/ProductContent/5
        public void Delete(int id)
        {
        }
    }
}
