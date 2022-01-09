namespace AuctionScraper.Models.Websites
{
    public class WebsiteList
    {
        public static GenericWebsite Hemmings = new GenericWebsite("https://www.hemmings.com/", "https://www.hemmings.com/classifieds?q=", "Ongoing", "//div[@class='lg:w-1/4 md:w-1/2 w-full md:mb-6']");
        //public static GenericWebsite Copart = new GenericWebsite("https://www.copart.com/", "https://www.copart.com/lotSearchResults?free=true&query=", "Set Day", "tr");
        public static GenericWebsite Capital = new GenericWebsite("https://www.capitalautoauction.com/", "https://www.capitalautoauction.com/inventory?f%5Bft_query%5D=", "Ongoing", "//div[@itemscope='itemscope']");
    }
}
