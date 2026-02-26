using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace WeatherAppForms.Models
{
    internal class WeatherResponse
    {
        [JsonPropertyName("name")] //attirbute namespace altinda bu adla calısır
        public string SehirAdi { get; set; } //veri al döndurru

        [JsonPropertyName("main")]
        public MainData AnaVeriler { get; set; }
    }
    internal class MainData //JSONdaki main objesini cek ve MainData classına maple.
    {
        [JsonPropertyName("temp")]
        public double Sicaklik { get; set; }

        [JsonPropertyName("feels_like")]
        public double Hissedilen { get; set; }
    }
}
