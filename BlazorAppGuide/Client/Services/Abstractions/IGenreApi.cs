using BlazorAppGuide.Shared.Dto;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BlazorAppGuide.Client.Services.Abstractions
{
    public interface IGenreApi
    {
        Task<string> Add(GenreDto model);
        Task<List<GenreDto>> GetAll();
        Task<GenreDto> GetById(int id);
        Task<string> Update(GenreDto model);
    }
}
