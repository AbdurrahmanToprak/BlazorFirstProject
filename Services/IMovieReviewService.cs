using MyBlazorApp.Models;

namespace MyBlazorApp.Services
{
    public interface IMovieReviewService
    {
        List<MovieModel>? GetMovies();
        MovieModel? GetMovieById(int id);
    }
}