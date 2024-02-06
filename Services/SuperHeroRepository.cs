using Epita_AutoMapper_Demo.Models;

namespace Epita_AutoMapper_Demo.Services
{
    public interface ISuperHeroRepository
    {
        public abstract static List<Superhero> SuperHeroes();
    }
    public class SuperHeroRepository :ISuperHeroRepository
    {

        public static List<Superhero> SuperHeroes()
        {
            throw new NotImplementedException();
        }
    }
}
