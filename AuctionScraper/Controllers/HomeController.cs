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
    Search searchItem = new Search("No Item");


    [HttpPost]
    public IActionResult SearchResults(string search)
    {
        searchItem.searchItem = search;
        ResultList resultList = new ResultList(GenericSiteParser.RetriveAuctionItemsHemmings(WebsiteList.Hemmings, search)/*, GenericSiteParser.RetrieveAuctionItemsCapital(WebsiteList.Capital, search)*/);
        return View(resultList);
    }
}

