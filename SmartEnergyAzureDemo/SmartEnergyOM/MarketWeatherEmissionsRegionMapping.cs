//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SmartEnergyOM
{
    using System;
    using System.Collections.Generic;
    
    public partial class MarketWeatherEmissionsRegionMapping
    {
        public int RegionMappingID { get; set; }
        public Nullable<int> MarketRegionID { get; set; }
        public Nullable<int> WeatherRegionID { get; set; }
        public Nullable<int> EmissionsRegionID { get; set; }
        public string FriendlyName { get; set; }
    
        public virtual EmissionsRegion EmissionsRegion { get; set; }
        public virtual MarketRegion MarketRegion { get; set; }
        public virtual WeatherRegion WeatherRegion { get; set; }
    }
}
