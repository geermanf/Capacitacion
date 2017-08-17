using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApi.Model;
using System.Net.Http;
using Newtonsoft.Json;
using WebApi.Service;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    public class NewsController : Controller
    {
        // GET api/values
        [HttpGet]
        public async Task<List<Doc>> GetNewsAsync(int beginDate, int endDate, string q)
        {
            NewsService service = new NewsService();
            RootObject root = new RootObject();
            root = await service.GetNewsAsync(beginDate, endDate, q);
            return root.response.docs;

        }
    }
}
