using Bouba_Store.Models.Domain;

namespace Bouba_Store.Models.Admin
{
    public class MovieListVm
    {

        public IQueryable<Movie>? MovieList { get; set; }
        public int PageSize { get; set; }
        public int CurrentPage { get; set; }
        public int TotalPages { get; set; }
        public string? Term { get; set; }

    }
}
