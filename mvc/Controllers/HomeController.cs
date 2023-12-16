using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using mvc.Models;
using Newtonsoft.Json;

namespace mvc.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    IWebHostEnvironment _appEnvironment;

    public HomeController(ILogger<HomeController> logger, IWebHostEnvironment appEnvironment)
    {
        _logger = logger;
        _appEnvironment= appEnvironment;
    }

    public IActionResult Index()
    {
        ViewBag.Attr1 = "/img/attr1.png";
        ViewBag.Attr2 = "/img/attr2.png";
        ViewBag.Attr5 = "/img/attr5.png";
        ViewBag.Attr6 = "/img/attr6.png";
        ViewBag.Correlation = "/img/correlation.png";
        ClassificationReport report =null;
        List<ClassificationReport> reports = new List<ClassificationReport>();

          string[] filePaths = Directory.GetFiles(Path.Combine(_appEnvironment.WebRootPath, "json"));
       
       foreach (var filePath in filePaths)
       {
           using (StreamReader reader = new StreamReader(filePath))
                {
                    string content = reader.ReadToEnd();
                    report = JsonConvert.DeserializeObject<ClassificationReport>(content);
                    report.ReportName =  Path.GetFileName(filePath.Split(".")[0]);
                    reports.Add(report);
                }
       }


        return View(reports);
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
