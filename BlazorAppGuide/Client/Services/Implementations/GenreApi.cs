using BlazorAppGuide.Client.Services.Abstractions;
using BlazorAppGuide.Shared.Dto;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace BlazorAppGuide.Client.Services.Implementations
{
    public class GenreApi : IGenreApi
    {
        private readonly string _endpoint = "api/genre";
        private readonly HttpClient _httpClient;

        public GenreApi(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<string> Add(GenreDto model)
        {
            var result = await _httpClient.PostAsJsonAsync(_endpoint, model);

            if(!result.IsSuccessStatusCode)
                return await result.Content.ReadAsStringAsync();

            return null;
        }

        public async Task<List<GenreDto>> GetAll()
        {
            return await _httpClient.GetFromJsonAsync<List<GenreDto>>($"{_endpoint}/all");
        }

        public async Task<GenreDto> GetById(int id)
        {
            return await _httpClient.GetFromJsonAsync<GenreDto>($"{_endpoint}/{id}");
        }

        public async Task<string> Update(GenreDto model)
        {
            var result = await _httpClient.PutAsJsonAsync(_endpoint, model);

            if (!result.IsSuccessStatusCode)
                return await result.Content.ReadAsStringAsync();

            return null;
        }
    }
}
