using System;
namespace AuctionScraper.Models
{
	public class Search
	{
		
		public string searchItem { get; set; }

		public Search(string search)
		{
			searchItem = search;
		}
	}
}

