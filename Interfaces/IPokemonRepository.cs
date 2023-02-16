using PokemonReview.Models;

namespace PokemonReview.Interfaces
{
    public interface IPokemonRepository
    {
        ICollection<Pokemon> GetPokemons();    
    }
}
