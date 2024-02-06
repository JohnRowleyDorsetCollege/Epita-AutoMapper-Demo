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

            return new List<Superhero>() {


             new Superhero {
         Id = 1,
         Name ="Spider Man",
         FirstName = "Peter",
         LastName = "Parker",
         Universe = "New York City",
         dateAdded = new DateTime(2001, 08, 10),
         dateUpdated = null 
     },
     new Superhero {
         Id = 2,
         Name ="Iron Man",
         FirstName = "Tony",
         LastName = "Stark",
         Universe = "Malibu",
         dateAdded = new DateTime(1970, 05, 29),
         dateUpdated = null
     }






            };
        }
    }



}


