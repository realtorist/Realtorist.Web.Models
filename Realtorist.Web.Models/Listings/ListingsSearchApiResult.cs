using Realtorist.Models.Models;

namespace Realtorist.Web.Models.Listings
{
    public class ListingsSearchApiResult
    {
        public string View { get; set; }

        public ListingCoordinates[] Coordinates { get; set; }
    }
}
