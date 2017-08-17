using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApi.Model;
using System.Net.Http;
using Newtonsoft.Json;

namespace WebApi.Service
{
    [Route("api/[controller]")]
    public class NewsService
    {
        public async Task<RootObject> GetNewsAsync(int beginDate, int endDate, string q)
        {
            var url = "https://api.nytimes.com/svc/search/v2/articlesearch.json?api-key=95d2b92b28de4dbeaec7e90da6ad3232&" +
                        "q="+ q +"&begin_date="+ beginDate + "&end_date=" + endDate + "&sort=newest&fl=web_url%2Csnippet%2Cheadline%2Cpub_date";

            var hc = new HttpClient();
            HttpResponseMessage response = await hc.GetAsync(url);
            response.EnsureSuccessStatusCode();
            string responseBody = await response.Content.ReadAsStringAsync();
            RootObject rootObject = JsonConvert.DeserializeObject<RootObject>(responseBody);
            
            foreach (var docs in rootObject.response.docs) 
            {
                HttpResponseMessage responseUrl = await hc.GetAsync(docs.web_url);
                if (responseUrl.IsSuccessStatusCode)
                {
                    docs.isValid = true;
                }
            }

            return rootObject;
        }
    }
}