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

        public static List<GenericAuction> RetrieveNews()
        {
            var nytimes = "https://www.nytimes.com/";
            var ny_response = CallUrl(nytimes).Result;
            HtmlDocument ny_htmlDocument = new HtmlDocument();
            ny_htmlDocument.LoadHtml(ny_response);
            var Nodes = new List<HtmlNode>();
            Nodes = ny_htmlDocument.DocumentNode.SelectNodes("//h3").ToList(); //.Where(x=>x.InnerHtml.Contains("story-wrapper")).ToList();
            var auctionItems = new List<GenericAuction>();
            foreach (var node in Nodes)
            {
                string title = node.InnerText;
                string url = "No Url";
                var urlParent = node.ParentNode.Ancestors();
                foreach (var urlNode in urlParent)
                {
                    if (urlNode.Name == "a")
                    {
                        url = urlNode.Attributes["href"].Value;
                    }
                }

                var item = new GenericAuction();
                auctionItems.Add(item);
            }
            return auctionItems;
        }
        public GenericSiteParser()
		{
		}
	}
}

