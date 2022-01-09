using System;
namespace AuctionScraper.Logic.AuctionSiteLogic
{
	public class GenericSiteParser
	{
        public static async Task<string> CallUrl(string fullUrl)
        {
            HttpClient client = new HttpClient();
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls13;
            client.DefaultRequestHeaders.Accept.Clear();
            var response = client.GetStringAsync(fullUrl);
            return await response;
        }

        public static List<HtmlNode> RetrieveItemNodes(GenericWebsite genericWebsite, string searchItem/*string searchUrl, string searchItem, string selectorNodes*/)
        {
            
            var searchResults = genericWebsite.WebsiteSearchUrl + searchItem;
            var searchResultsResponse = CallUrl(searchResults).Result;
            HtmlDocument htmlDocument = new HtmlDocument();
            htmlDocument.LoadHtml(searchResultsResponse);
            var Nodes = new List<HtmlNode>();
            Nodes = htmlDocument.DocumentNode.SelectNodes(genericWebsite.SelectNodes).ToList();


            return Nodes;

        }

        public static List<HemmingsAuction> RetriveAuctionItemsHemmings(GenericWebsite genericWebsite, string searchItem)
        {
            List<HtmlNode> Nodes = RetrieveItemNodes(genericWebsite, searchItem);
            var auctionItems = new List<HemmingsAuction>();
            foreach (var node in Nodes)
            {
                
                string auctionItem = "No Item Name";
                string url = "No Url";
                string pictureURL = "No Picture";
                string currentBid = "No Bid Avalaible";
                string auctionEndDate = "No End Date Avialable";
               
                foreach (var subNode in node.Descendants())
                {
                    if (subNode.Name == "a" && subNode.InnerHtml.Contains("img"))
                    {
                        url = subNode.Attributes["href"].Value;
                        pictureURL = subNode.Element("img").Attributes["src"].Value; //FirstChild.Attributes["src"].Value;
                    }
                    if (subNode.Name == "a" && subNode.Name != "//a[@class='block text-green-700 relative']")
                    {
                        auctionItem = subNode.InnerHtml;
                    }
                    if (subNode.InnerText.Contains("$"))
                    {
                        currentBid = subNode.InnerText;
                    }
                    /*
                    if (subNode.Name == "//div[@class='flex flex-row']")
                    {
                        string htmlString = subNode.InnerHtml;
                        int days = int.Parse(Regex.Match(htmlString, @"\d+").Value);
                        var currentDate = DateTime.UtcNow.Date;
                        auctionEndDate = currentDate.AddDays(days).ToString("dd / MM / yyyy");

                    }*/
                    /*
                    string htmlString =subNode.SelectSingleNode("//div[@class='flex flex-row']").InnerHtml;
                    int days = int.Parse(Regex.Match(htmlString, @"\d+").Value);
                    var currentDate = DateTime.UtcNow.Date;
                    auctionEndDate = currentDate.AddDays(days).ToString("dd / MM / yyyy");
                    */

                }

                var item = new HemmingsAuction(auctionItem, "Hemmings", url, pictureURL, "Ongoing", currentBid, auctionEndDate);
                auctionItems.Add(item);
            }
            return auctionItems;


        }
        public static List<CopartAuction> RetrieveAuctionItemsCopart(GenericWebsite genericWebsite, string searchItem)
        {
            List<HtmlNode> Nodes = RetrieveItemNodes(genericWebsite, searchItem);
            var auctionItems = new List<CopartAuction>();
            foreach (var node in Nodes)
            {

                string auctionItem = "No Item Name";
                string url = "No Url";
                string pictureURL = "No Picture";
                string currentBid = "No Bid Avalaible";
                string auctionEndDate = "No End Date Avialable";

                foreach(var subNode in node.Descendants())
                {
                    url = subNode.SelectSingleNode("//span[@class='search_result_lot_detail']").ParentNode.Attributes["href"].Value;
                    auctionItem = subNode.SelectSingleNode("//span[@class='search_result_lot_detail']").InnerHtml;
                    pictureURL = subNode.SelectSingleNode("//img[@class='ng-star-inserted']").Attributes["src"].Value;
                    currentBid = subNode.SelectSingleNode("//span[@class='search_result_lot_detail']").InnerHtml;
                    auctionEndDate = subNode.SelectSingleNode("//span[@class='ng-star-inserted']").InnerHtml;
                }
                var item = new CopartAuction(auctionItem, "Copart", url, pictureURL, "Set Date", currentBid, auctionEndDate);
                auctionItems.Add(item);
            }
            return auctionItems;
        }
        public static List<HemmingsAuction> RetrieveAuctionItemsCapital(GenericWebsite genericWebsite, string searchItem)
        {
            List<HtmlNode> Nodes = RetrieveItemNodes(genericWebsite, searchItem);
            var auctionItems = new List<HemmingsAuction>();
            foreach (var node in Nodes)
            {

                string auctionItem = "No Item Name";
                string url = "No Url";
                string pictureURL = "No Picture";
                string currentBid = "No Bid Avalaible";
                string auctionEndDate = "No End Date Avialable";

                foreach (var subNode in node.Descendants())
                {
                    url = subNode.SelectSingleNode("//a[@class='button card__button-bid button--small']").Attributes["href"].Value;
                    auctionItem = subNode.SelectSingleNode("//h3").InnerHtml;
                    pictureURL = subNode.SelectSingleNode("//img").Attributes["src"].Value;
                    currentBid = subNode.SelectSingleNode("//div[@class='card__bid-value']").InnerHtml;
                    //auctionEndDate = subNode.SelectSingleNode("//span[@class='ng-star-inserted']").InnerHtml;
                }
                var item = new HemmingsAuction(auctionItem, "Capital Auto Auction", url, pictureURL, "Ongoing", currentBid, auctionEndDate);
                auctionItems.Add(item);
            }
            return auctionItems;
        }
        public GenericSiteParser()
		{
		}
	}
}

