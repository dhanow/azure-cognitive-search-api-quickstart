using System;
using Microsoft.Azure.Search;
using Microsoft.Azure.Search.Models;
using Newtonsoft.Json;

namespace AzureSearchQuickstart
{

    //The hotels index consists of simple and complex fields, where a simple field is "HotelName" or "Description", 
    //and complex fields are an address with subfields, or a collection of rooms. When an index includes complex types, 
    //isolate the complex field definitions in separate classes.

    public partial class Address
    {
        [IsSearchable]
        public string StreetAddress { get; set; }

        [IsSearchable, IsFilterable, IsSortable, IsFacetable]
        public string City { get; set; }

        [IsSearchable, IsFilterable, IsSortable, IsFacetable]
        public string StateProvince { get; set; }

        [IsSearchable, IsFilterable, IsSortable, IsFacetable]
        public string PostalCode { get; set; }

        [IsSearchable, IsFilterable, IsSortable, IsFacetable]
        public string Country { get; set; }
    }
}

