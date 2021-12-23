using System;
namespace AuctionScraper.Models.Auctions
{
	public class AuctionDate : GenericAuction
	{
		public DateOnly AuctionDay { get; set; }
		public decimal PriceEstimateLow { get; set; }
		public decimal PriceEstimateHigh { get; set; }
	}
}

