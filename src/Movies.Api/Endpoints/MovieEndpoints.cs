namespace Kritikos.Training.Movies.Api.Endpoints;

using Kritikos.Training.Movies.Data.Models;
using Kritikos.Training.Movies.Data.Models.Movie;

using Microsoft.AspNetCore.Http.HttpResults;

/// <summary>
/// TODO: fill the following methods with the appropriate logic.
/// You will need to remove the return type and replace it with the appropriate one.
/// </summary>
/// <remarks>
/// Showcasing Create-Retrieve-Update-Delete (CRUD) operations.
/// </remarks>
internal static class MovieEndpoints
{
  // TODO: Fill data after adding properties to the Movie Class
  private readonly static List<Movie> Movies = new() { new Movie { }, new Movie { }, new Movie { }, new Movie { } };

  // TODO: map endpoints, ie: group.MapGet("", GetMovies);
  // Valid route templates: https://learn.microsoft.com/en-us/aspnet/core/fundamentals/routing?view=aspnetcore-8.0#endpoints
  internal static IEndpointRouteBuilder MapMovieEndpoints(this IEndpointRouteBuilder app)
  {
    var group = app.MapGroup("api/movie").WithTags("Movie");
    group.MapGet(string.Empty, GetMovies);
    group.MapGet("{id:int}", GetMovie);
    group.MapPut("{id:int}", UpdateMovie);
    group.MapDelete("{id:int}", DeleteMovie);

    return app;
  }

  internal static Ok<List<Movie>> GetMovies()
  {
    return TypedResults.Ok(Movies);
  }

  internal static Results<Ok, NotFound> GetMovie(int id)
  {
    return TypedResults.NotFound();
  }

  internal static Results<Ok<MovieDto>, BadRequest> CreateMovie(CreateMovie movie)
  {
    return TypedResults.BadRequest();
  }

  internal static Results<Ok, BadRequest, NotFound> UpdateMovie(int id, UpdateMovie movie)
  {
    return TypedResults.BadRequest();
  }

  internal static Results<NoContent, NotFound> DeleteMovie(int id)
  {
    return TypedResults.NotFound();
  }
}
