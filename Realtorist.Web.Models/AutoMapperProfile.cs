using Realtorist.Models.Blog;
using Realtorist.Models.Listings;
using Realtorist.Models.CustomerRequests;
using Realtorist.Models.Page;
using Realtorist.Models.Settings;
using Realtorist.Web.Models.Listings;

namespace Realtorist.Web.Models
{
    /// <summary>
    /// Defines mapper profile for models
    /// </summary>
    public class AutoMapperProfile : AutoMapper.Profile
    {
        /// <summary>
        /// Default ctr
        /// </summary>
        public AutoMapperProfile()
        {
            CreateMap<Listing, ListingLinkModel>();
        }
    }
}