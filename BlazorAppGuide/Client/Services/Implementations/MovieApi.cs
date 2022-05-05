using BlazorAppGuide.Client.Services.Abstractions;
using Model.Entitties;
using System;
using System.Collections.Generic;
using System.Net.Http;

namespace BlazorAppGuide.Client.Services.Implementations
{
    public class MovieApi : IMovieApi
    {
        private readonly string _endpoint = "api/movie";
        private readonly HttpClient _httpClient;

        public MovieApi(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public List<Movie> GetMovies()
        {
            return new List<Movie>()
            {
                new Movie {Title = "Spiderman: Homecoming", Poster = "https://es.web.img2.acsta.net/pictures/17/06/19/14/01/130456.jpg", ReleaseDate = new DateTime(2017, 6, 28) },
                new Movie {Title = "Spiderman: Far From Home", Poster = "https://pics.filmaffinity.com/Spider_Man_Lejos_de_casa-176834859-large.jpg", ReleaseDate = new DateTime(2019, 7, 4) },
                new Movie {Title = "Spiderman: Homecoming", Poster = "https://hips.hearstapps.com/hmg-prod.s3.amazonaws.com/images/poster-spider-man-no-way-home-1637136793.jpg",ReleaseDate = new DateTime(2021, 12, 15) }
            };
        }
    }
}
