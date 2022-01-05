using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using AuctionScraper.Models;

namespace AuctionScraper.Controllers;

public class HomeController : Controller
{
    
    public enum Websites {
        

    }
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        ViewData["searchItem"] = searchItem;
        return View(searchItem);
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
    Search searchItem = new Search("No Item");

    
    [HttpPost]
    public string Search(string search)
    {
        searchItem.searchItem = search;

        return search;
    }
    

}

