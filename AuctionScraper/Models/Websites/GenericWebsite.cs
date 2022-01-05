using System;
using AuctionScraper.Models.Auctions;

namespace AuctionScraper.Models.Websites
{
	public class GenericWebsite
	{
		public string WebsiteBaseUrl { get; set; }
		public string WebsiteSearchUrl { get; set; }
		public string AuctionType { get; set; }
		public string SelectNodes { get; set; }

		/*
		public static List<GenericAuction> GetGenericAuctions()
        {

        }*/
		public GenericWebsite(string websiteBaseUrl, string websiteSearchUrl, string auctionType, string selectNodes)
		{
			WebsiteBaseUrl = websiteBaseUrl;
			WebsiteSearchUrl = websiteSearchUrl;
			AuctionType = auctionType;
			SelectNodes = selectNodes;
		}

		public GenericWebsite Hemmings = new GenericWebsite("https://www.hemmings.com/", "https://www.hemmings.com/classifieds?q=", "Ongoing", "div[@class='lg:w-1/4 md:w-1/2 w-full md:mb-6']");
	}


}

