using System;
namespace AuctionScraper.Models.Auctions
{
	public class AuctionOngoing : GenericAuction
	{
		public DateOnly AuctionStart { get; set; }
		public DateOnly AuctionEnd { get; set; }
		public decimal StartPrice { get; set; }
		public decimal CurrentPrice { get; set; }
	}
}

