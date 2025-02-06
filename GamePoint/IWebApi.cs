using GamePoint.WebAPI.Models;
using Refit;

namespace GamePoint.WebAplication
{
    public interface IWebApi
    {
        [Get("/gettasks")]
        Task<List<GamePointModel>> GetGamePoints();
    }
}
