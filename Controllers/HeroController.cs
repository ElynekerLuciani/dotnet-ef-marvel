using System.Linq;
using dotnet_ef_marvel.src.Database;
using dotnet_ef_marvel.src.Dto;
using dotnet_ef_marvel.src.Entities;
using Microsoft.AspNetCore.Mvc;

namespace dotnet_ef_marvel.Controllers
{
    [ApiController]
    [Route("api/v1/heros")]
    public class HeroController
    {
        private DataContext _context { get; set; }

        public HeroController(DataContext context)
        {
            this._context = context;
        }

        [HttpPost]
        public Hero Create(CreateHero hero)
        {
            var newHero = new Hero(hero);

            _context.heroes.Add(newHero);
            _context.SaveChanges();

            return newHero;
        }

        [HttpGet("{id:int}")]
        public Hero GetById(int id)
        {
            var result = _context.heroes.FirstOrDefault(h => h.Id == id);
            return result;
        }

    }
}