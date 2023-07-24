using Refit;

namespace RefitClientPlayground;

public interface IStarsController
{
    [Get("/{count}")]
    Task<string> GetAsync(int count);
    [Get("/double/{count}")]
    Task<string> GetDoubleAsync(int count);
}