namespace Epita_AutoMapper_Demo.Models
{
    public class Superhero
    {
        public  int  Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;

        public string Universe { get; set; } = string.Empty;

        public DateTime? dateAdded { get; set; }
        public DateTime? dateUpdated { get; set;}

    }
}
