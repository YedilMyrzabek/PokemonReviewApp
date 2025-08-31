namespace PokemonReviewApp.Models;

public class Pokemon
{
    public Guid  Id { get; set; } 
    public string Name { get; set; }
    public DateTime BirthDate { get; set; }
}