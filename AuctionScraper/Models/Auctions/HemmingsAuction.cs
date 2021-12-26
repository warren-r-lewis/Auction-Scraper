using System;
namespace AuctionScraper.Models.Auctions
{
	public class HemmingsAuction: GenericAuction
	{
		public string CurrentBid { get; set; }
		public string EndDate { get; set; }
		public HemmingsAuction(string itemName, string websiteName, string url, string picture, string auctionType, string currentbid, string endDate)
		{
			ItemName = itemName;
			WebsiteName = websiteName;
			Url = url;
			Picture = picture;
			AuctionType = auctionType;
			CurrentBid = currentbid;
			EndDate = endDate;
		}
	}
}

