using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using WeatherAppForms.Models;

namespace WeatherAppForms.Services
{
    internal class WeatherService
    {
        // bir kere atama için readonly her zamn kullanilmasi icin static
        //sürekli olsuturulursa socket exhaustion hatası verir
        private static readonly HttpClient _httpClient = new HttpClient();

        //api key
        private readonly string _apiKey = "YOUR_API_KEY";

        //'async' dönüş tipi 'Task<T>'
        public async Task<WeatherResponse> GetWeatherAsync(string city)
        {

            // units=metric: Santigrat tip.
            // lang=tr: dil
            string url = $"https://api.openweathermap.org/data/2.5/weather?q={city}&appid={_apiKey}&units=metric&lang=tr";

            try
            {
                // get istegi at /  await thread block icin gerekli 
                HttpResponseMessage response = await _httpClient.GetAsync(url);

                //200 dısındaki kodları dondursun diye
                response.EnsureSuccessStatusCode();

                // ham json veri
                string jsonResponse = await response.Content.ReadAsStringAsync();
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine($"ham json denegi{jsonResponse}");
                Console.ResetColor();

                // gelen json verisini dtomuza donusturuyoruz
                WeatherResponse weatherData = JsonSerializer.Deserialize<WeatherResponse>(jsonResponse);

                return weatherData; //dolu nesneyi döndur
            }
            catch (HttpRequestException ex)//hata yakalamanmasi ciin
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"\n[Hata] Hava durumu verisi çekilemedi! Detay: {ex.Message}");
                Console.ResetColor();
                return null;
            }
        }
    }
}
