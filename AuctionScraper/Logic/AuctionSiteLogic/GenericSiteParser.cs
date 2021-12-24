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

		public GenericSiteParser()
		{
		}
	}
}

