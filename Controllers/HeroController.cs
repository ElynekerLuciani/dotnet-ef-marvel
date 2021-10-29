using dotnet_ef_marvel.src.Dto;
using Microsoft.AspNetCore.Mvc;

namespace dotnet_ef_marvel.Controllers
{
    [ApiController]
    [Route("api/v1/heros")]
    public class HeroController
    {
        [HttpPost]
        public CreateHero Create(CreateHero hero)
        {
            return hero;
        }

    }
}