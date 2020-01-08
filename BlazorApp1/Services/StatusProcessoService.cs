using BlazorApp1.Models;
using Microsoft.AspNetCore.Components;
using System;
using System.Net.Http;
using System.Threading.Tasks;


namespace BlazorApp1.Services
{
    public class StatusProcessoService : IStatusProcessoService
    {
        private readonly HttpClient _httpClient;

        public StatusProcessoService()
        {
            _httpClient = new HttpClient();
            _httpClient.BaseAddress = new Uri("http://localhost:3000");
            _httpClient.DefaultRequestHeaders.Add("Accept", "application/json");
        }

        public async Task<SelectValueText[]> ListarStatus()
        {
            var response = await _httpClient.GetJsonAsync<SelectValueText[]>("statusprocessos");
            return response;
        }

        public async Task<string> ListarProcessoPorStatus()
        {
            return await Task.FromResult("listar processos.");
        }
    }
}
