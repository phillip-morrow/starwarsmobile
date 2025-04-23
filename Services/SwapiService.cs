using System.Net.Http.Json;
using StarWarsMobile.Models;

namespace StarWarsMobile.Services
{
    public class SwapiService
    {
        private readonly HttpClient _httpClient;

        public SwapiService()
        {
            _httpClient = new HttpClient { BaseAddress = new Uri("https://swapi.dev/api/") };
        }

        public async Task<List<Character>> GetCharactersAsync()
        {
            var response = await _httpClient.GetFromJsonAsync<SwapiResponse<Character>>("people/");
            return response?.Results ?? new List<Character>();
        }

        public async Task<List<Ship>> GetShipsAsync()
        {
            var response = await _httpClient.GetFromJsonAsync<SwapiResponse<Ship>>("starships/");
            return response?.Results ?? new List<Ship>();
        }

        public async Task<List<Movie>> GetMoviesAsync()
        {
            var response = await _httpClient.GetFromJsonAsync<SwapiResponse<Movie>>("films/");
            return response?.Results ?? new List<Movie>();
        }
    }

    public class SwapiResponse<T>
    {
        public List<T> Results { get; set; }
    }
}