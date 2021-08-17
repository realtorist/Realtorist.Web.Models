using System;
using Realtorist.Models.Listings.Details;

namespace Realtorist.Web.Models.Listings
{
    public class ListingLinkModel
    {
        public Guid Id { get; set; }

        public Address Address { get; set; }
    }
}