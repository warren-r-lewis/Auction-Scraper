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

		
	}


}

