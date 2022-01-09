namespace AuctionScraper.Models.Auctions
{
    public class CopartAuction: GenericAuction
    {
        public string CurrentBid { get; set; }
        public string AuctionDate { get; set; }
		public CopartAuction(string itemName, string websiteName, string url, string picture, string auctionType, string currentbid, string endDate)
		{
			ItemName = itemName;
			WebsiteName = websiteName;
			Url = url;
			Picture = picture;
			AuctionType = auctionType;
			CurrentBid = currentbid;
			AuctionDate = endDate;
		}
	}
}
