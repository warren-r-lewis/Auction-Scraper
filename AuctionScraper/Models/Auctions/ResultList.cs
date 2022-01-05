namespace AuctionScraper.Models.Auctions
{
    public class ResultList
    {
        public List<HemmingsAuction> HemmingsAuction { get; set; }
        public ResultList(List<HemmingsAuction> hemmingsAuction)
        {
            HemmingsAuction = hemmingsAuction;
        }

    }
}
