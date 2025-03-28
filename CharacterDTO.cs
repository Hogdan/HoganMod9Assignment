public class CharacterDTO
{
    public UInt64 Id { get; set; }
    public string? Name { get; set; }
    public string? Species { get; set; }
    public List<string> Series { get; set; } = [];
    public List<string> Alias { get; set; } = [];

    public string Display()
    {
        return $"Name: {Name}\nSpecies: {Species}\n";
    }
}