using BlazorAppGuide.Shared;
using BlazorAppGuide.Shared.Dto;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BlazorAppGuide.Client.Services.Abstractions
{
    public interface IActorApi
    {
        Task<string> Add(ActorDto model);
        Task<List<ActorDto>> GetAll();
        Task<List<SelectItem<int>>> GetAsGenericList();
    }
}
