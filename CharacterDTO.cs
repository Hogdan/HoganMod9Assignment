public class CharacterDTO
{
  public UInt64 Id { get; set; }
  public string? Name { get; set; }
  public List<string> Series { get; set; } = [];
  public string Display()
  {
    return $"Name: {Name}\nSeries: {string.Join(", ", Series)}\n";
  }
}