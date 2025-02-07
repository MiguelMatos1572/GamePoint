using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using GamePoint.WebAPI.Models;
using Refit;
using GamePointDB.Entity;
using GamePointDB.Data;

namespace GamePoint.WebAplication
{
    public interface IWebApi
    {
        [Get("/gettasks")]
        Task<List<GamePointModel>> GetGamePoints();
    }
}
