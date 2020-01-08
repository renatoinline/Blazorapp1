using BlazorApp1.Models;
using System.Threading.Tasks;

namespace BlazorApp1.Services
{
    public interface IWeatherForecastService
    {
        public Task<WeatherForecast[]> GetForecast();
    }
}
