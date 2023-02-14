namespace PokemonReview.Models
{
    public class Reviewer
    {
        public int Id { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public ICollection<Review> Reviews { get; set;}
    }
}
