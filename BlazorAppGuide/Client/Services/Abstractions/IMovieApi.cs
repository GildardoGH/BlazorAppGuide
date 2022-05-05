using Model.Entitties;
using System.Collections.Generic;

namespace BlazorAppGuide.Client.Services.Abstractions
{
    public interface IMovieApi
    {
        List<Movie> GetMovies();
    }
}
