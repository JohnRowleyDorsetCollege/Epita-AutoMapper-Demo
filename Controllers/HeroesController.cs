using AutoMapper;
using Epita_AutoMapper_Demo.Models;
using Epita_AutoMapper_Demo.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Epita_AutoMapper_Demo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HeroesController : ControllerBase
    {
        private readonly IMapper _mapper;
        public HeroesController(IMapper mapper)
        {
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult GetHeroes()
        {
            return Ok(SuperHeroRepository.SuperHeroes().Select(hero=>_mapper.Map<SuperheroDTO>(hero)));
        }
    }
}

// create a controller
// create a service to return a list (3+) heroes 
// create an action that calls the service




// OOP topics - SOLID
// Single Responsibility Principle
// Open closed Principle
// Liskov Substitution Principle
// Interface Segregation principle
// Dependency Inversion Principle
