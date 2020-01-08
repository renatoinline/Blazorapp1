using BlazorApp1.Models;
using Microsoft.AspNetCore.Components;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace BlazorApp1.Services
{
    public class WeatherForecastService : IWeatherForecastService
    {
        private readonly HttpClient _httpClient;

        public WeatherForecastService()
        {
            _httpClient = new HttpClient();
            _httpClient.BaseAddress = new Uri("https://localhost:44364/");
            _httpClient.DefaultRequestHeaders.Add("Accept", "application/json");
        }

        public async Task<WeatherForecast[]> GetForecast()
        {
            var response = await _httpClient.GetJsonAsync<WeatherForecast[]>("sample-data/weather.json");
            return response;
        }
    }
}
