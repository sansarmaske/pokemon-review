using PokemonReview.Models;

namespace PokemonReview
{
    public class Pokemon
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string BirthDate { get; set; } 
        public ICollection<Review> Reviews { get;}
    }
}
