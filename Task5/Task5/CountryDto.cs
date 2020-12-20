using System;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace Task5
{
    [DataContract]
    public class CountryDto
    {
        [DataMember(Name = "name")]
        public string Name { get; set; }

        [DataMember(Name = "capital")]
        public string Capital { get; set; }

        [DataMember(Name = "region")]
        public string Region { get; set; }

        [DataMember(Name = "population")]
        public double? Population { get; set; }

        [DataMember(Name = "area")]
        public double? Area { get; set; }

        [DataMember(Name = "latlng")]
        public double[] LatLng { get; set; }

        [DataMember(Name = "currencies")]
        public string[] Currencies { get; set; }

        [DataMember(Name = "alpha3Code")]
        public string Alpha3Code { get; set; }

    }
}
