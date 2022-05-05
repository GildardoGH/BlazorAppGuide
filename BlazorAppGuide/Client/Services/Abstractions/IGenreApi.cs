using BlazorAppGuide.Shared.Dto;
using System.Threading.Tasks;

namespace BlazorAppGuide.Client.Services.Abstractions
{
    public interface IGenreApi
    {
        Task<string> Add(GenreDto model);
    }
}
