using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using sampleapp.Models;



public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
  

        // var options = new RestClientOptions("http://localhost:50547")
        // {
        // MaxTimeout = -1,
        // };

        // var client = new RestClient(options);
        // var request = new RestRequest("/v1/chat/completions", Method.Post);
        // request.AddHeader("Content-Type", "application/json");
        // var body = @"{" + "\n" +
        // @"  ""messages"": [" + "\n" +
        // @"    {" + "\n" +
        // @"      ""content"": ""You are a helpful assistant.""," + "\n" +
        // @"      ""role"": ""system""" + "\n" +
        // @"    }," + "\n" +
        // @"    {" + "\n" +
        // @"      ""content"": ""What is the capital of France?""," + "\n" +
        // @"      ""role"": ""user""" + "\n" +
        // @"    }" + "\n" +
        // @"  ]" + "\n" +
        // @"}";
        // request.AddStringBody(body, DataFormat.Json);
        // RestResponse response = await client.ExecuteAsync(request);
        // Console.WriteLine(response.Content);


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
