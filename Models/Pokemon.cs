namespace PokemonReview.Models
{
    public class Pokemon
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string BirthDate { get; set; }
        public ICollection<Review> Reviews { get; }
        public ICollection<PokemonOwner> PokemonOwner { get; set; }
        public ICollection<PokemonCategory> PokemonCategory { get; set; }

         
    }
}
