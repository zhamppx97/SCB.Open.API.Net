using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SCB.Open.API.Net;
using System;
using System.Diagnostics;
using System.Threading.Tasks;
using Web.App.Models;

namespace Web.App.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public async Task<IActionResult> Index()
        {
            SCBOpenAPI.Authentication auth = new SCBOpenAPI.Authentication();

            auth.CreateTokenRequestHeader.ContentType = "application/json";
            auth.CreateTokenRequestHeader.ResourceOwnerId = "<Your API Key>";
            auth.CreateTokenRequestHeader.RequestUId = Guid.NewGuid().ToString();
            auth.CreateTokenRequestHeader.AcceptLanguage = "EN";

            auth.CreateTokenRequestBody.applicationKey = "<Your API Key>";
            auth.CreateTokenRequestBody.applicationSecret = "<Your API Secret>";
            auth.CreateTokenRequestBody.authCode = null;
            auth.CreateTokenRequestBody.state = null;
            auth.CreateTokenRequestBody.codeChallenge = null;

            var resultToken = await auth.GetTokenAsync(auth.CreateTokenRequestHeader, auth.CreateTokenRequestBody);
            ViewBag.Results = resultToken.jsonString;

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
