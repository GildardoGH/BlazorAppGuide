using BlazorAppGuide.Client.Services.Abstractions;
using BlazorAppGuide.Shared.Dto;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace BlazorAppGuide.Client.Services.Implementations
{
    public class ActorApi : IActorApi
    {
        private readonly string _endpoint = "api/actor";
        private readonly HttpClient _httpClient;

        public ActorApi(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<string> Add(ActorDto model)
        {
            var result = await _httpClient.PostAsJsonAsync(_endpoint, model);

            if (!result.IsSuccessStatusCode)
                return await result.Content.ReadAsStringAsync();

            return null;
        }

        public async Task<List<ActorDto>> GetAll()
        {
            return await _httpClient.GetFromJsonAsync<List<ActorDto>>($"{_endpoint}/all");
        }
    }
}
