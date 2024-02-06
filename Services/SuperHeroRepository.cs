using Epita_AutoMapper_Demo.Models;
using System.Reflection.Metadata.Ecma335;

namespace Epita_AutoMapper_Demo.Services
{
    public interface ISuperHeroRepository
    {
        public abstract static List<Superhero> SuperHeroes();
    }
    public class SuperHeroRepository : ISuperHeroRepository
    {

        public static List<Superhero> SuperHeroes()
        {

            return new List<Superhero>();
        }
    }



}


