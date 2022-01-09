namespace AuctionScraper.Models.Auctions
{
    public class ResultList
    {
        public List<HemmingsAuction> HemmingsAuction { get; set; }
        //public List<CopartAuction> CopartAuction { get; set; }
        public List<HemmingsAuction> Capital { get; set; }
        public ResultList(List<HemmingsAuction> hemmingsAuction, /*List<CopartAuction> copartAuction,*/ List<HemmingsAuction> capital)
        {
            HemmingsAuction = hemmingsAuction;
            //CopartAuction = copartAuction;
            Capital = capital;
        }

    }
}
