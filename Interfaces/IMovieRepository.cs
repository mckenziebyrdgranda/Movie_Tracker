﻿using Movie_Tracker.Models;

namespace Movie_Tracker.Interfaces
{
    public interface IMovieRepository
    {
        List<Movie> GetAllMovies();
        Movie GetMovieById(int Id);
        List<Movie> GetFavorites();
        List<Movie> GetWatched();
        List<Movie> GetUnwatched();
        void DeleteMovie(int Id, int UserId);
    }
}
