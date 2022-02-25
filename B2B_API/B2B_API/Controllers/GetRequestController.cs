using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using B2B_API.Model;
using RestSharp;
using System.Net;

namespace B2B_API.Controllers
{
    [Authorize]
    [ApiController]
    [Route("api/[controller]")]
    public class GetRequestController : ControllerBase
    {
        

        private readonly ILogger<GetRequestController> _logger;

        public GetRequestController(ILogger<GetRequestController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetData")]
        public string Get()
        {
            //request sonucu gelen veri modele çevrilir işlemler yapılır.
            GenericModel obj = new GenericModel();
            

            return obj.Name;
        }
    }

    class Connect
    {
        public Task<RestResponse> SendRequest(string url, string body, Method method, string headerUrl)
        {
            ServicePointManager.Expect100Continue = true;
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;

            var client = new RestClient($"{url}");
      
            RestRequest request = new RestRequest(method.ToString());

            request.AddHeader("Content-Type", "text/xml;charset=UTF-8");
            request.AddHeader($"SOAPAction", $"{headerUrl}");

            request.AddHeader("Authorization", "Basic dG9rZGVtaXJiaWxpc2ltOkdUYWhqMA==");





            if (!string.IsNullOrEmpty(body))
            {
                request.AddParameter("text/xml;charset=UTF-8", body, ParameterType.RequestBody);
            }
            Task<RestResponse> response = client.ExecuteGetAsync(request);

            return response;
        }
    }
}