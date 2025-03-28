using System.Text.Json;

// deserialize mario json from file into List<Mario>
List<Character> dks = JsonSerializer.Deserialize<List<Character>>(File.ReadAllText("dk.json"))!;
// deserialize mario json from file into List<Mario>
List<Character> marios = JsonSerializer.Deserialize<List<Character>>(File.ReadAllText("mario.json"))!;
// combine all characters into 1 list
List<Character> characters = [];
characters.AddRange(dks);
characters.AddRange(marios);

// display all characters
// foreach(Character character in characters)
// {
//   Console.WriteLine(character.Display());
// }
Console.Clear();

// display first character
// Console.WriteLine(characters.First().Display());

// display the first 5 characters
// foreach(Character character in characters.Take(5))
// {
//   Console.WriteLine(character.Display());
// }

// display every character except the first 5
// foreach(Character character in characters.Skip(5))
// {
//   Console.WriteLine(character.Display());
// }

// display characters 6-10
// foreach(Character character in characters.Skip(5).Take(5))
// {
//   Console.WriteLine(character.Display());
// }

// display last character
// Console.WriteLine(characters.Last().Display());

// first year character created
// Console.WriteLine(characters.Min(c => c.YearCreated));

// oldest character
// Console.WriteLine(characters.First(c => c.YearCreated == characters.Min(c => c.YearCreated)).Display());

// are there any characters created in 1995?
// bool Character1995 = characters.Any(c => c.YearCreated == 1995);
// Console.WriteLine($"Are there characters created in 1995: {Character1995}");
// how many characters were created in 1995
// Console.WriteLine($"How many? {characters.Count(c => c.YearCreated == 1995)}");
// which characters were created in 1995
// foreach(CharacterDTO characterDTO in characters.Where(c => c.YearCreated == 1995).Select(c => new CharacterDTO{ Id = c.Id, Name = c.Name, Series = c.Series }).OrderBy(c => c.Name))
// {
//   Console.WriteLine(characterDTO.Display());
// }

// how many characters in total (all series)?
// int CharacterCount = characters.Count();
// Console.WriteLine($"There are {CharacterCount} characters in all series");
// how many characters appear in the Mario series?
// int MarioCount = characters.Where(c => c.Series.Contains("Mario")).Count();
// Console.WriteLine($"There are {MarioCount} characters in the Mario series");
// how many characters appear in the Donkey Kong series?
// int DkCount = characters.Where(c => c.Series.Contains("Donkey Kong")).Count();
// Console.WriteLine($"There are {DkCount} characters in the Donkey Kong series");
// how many characters appear in the Mario & Donkey Kong series?
// int DkMarioCount = characters.Where(c => c.Series.Contains("Donkey Kong") && c.Series.Contains("Mario")).Count();
// Console.WriteLine($"There are {DkMarioCount} characters that appear in Mario and Donkey Kong series");
// which characters (name only) appear in Mario and Donkey Kong?
// foreach(String? name in characters.Where(c => c.Series.Contains("Donkey Kong") && c.Series.Contains("Mario")).Select(c => c.Name))
// {
//   Console.WriteLine($"\t{name}");
// }
// how many characters appear in Donkey Kong and not in Mario?
// int DkNotMarioCount = characters.Where(c => c.Series.Contains("Donkey Kong") && !c.Series.Contains("Mario")).Count();
// Console.WriteLine($"There are {DkNotMarioCount} characters that appear in Donkey Kong and Not in Mario series");

// which character(s) has/have the most alias's?
// foreach(var obj in characters.Where(c => c.Alias.Count() == characters.Max(c => c.Alias.Count())).Select(c => new {c.Name, c.Alias})){
//   Console.WriteLine($"{obj.Name} has {obj.Alias.Count()} alias(s):\n\t{String.Join(", ", obj.Alias)}");
// }

// how many letters make up the longest character name(s)
// int LengthOfName = characters.Max(c => c.Name!.Length);
// Console.WriteLine($"There are {characters.Max(c => c.Name!.Length)} letters in the longest character's name");
// which characters have the longest name?
// foreach(string? name in characters.Where(c => c.Name!.Length == LengthOfName).Select(c => c.Name))
// {
//   Console.WriteLine($"\t{name}");
// }

// all characters grouped by year created
// var CharactersByYearCreated = characters.GroupBy(c => c.YearCreated);
// foreach(var characterByYearCreated in CharactersByYearCreated)
// {
//   Console.WriteLine(characterByYearCreated.Key);
//   foreach(var character in characterByYearCreated) {
//     Console.WriteLine($"\t{character.Name}");
//   }
// }

// Display characters created in 1981 (all series)
// Console.WriteLine($"Characters created in 1981 - {characters.Count(c => c.YearCreated == 1981)}");

// List the characters created in 1981 (all series)
// foreach(CharacterDTO characterDTO in characters.Where(c => c.YearCreated == 1981).Select(c => new CharacterDTO{ Name = c.Name, Series = c.Series}))
// {
//     Console.WriteLine(characterDTO.Display());
// }

// Display number of characters created in 1981 (Mario series)
// Console.WriteLine($"Mario series characters created in 1981 - {characters.Count(c => c.YearCreated == 1981 && c.Series.Contains("Mario"))}");

// List the characters created in 1981 (Mario series) name only
// foreach(string? name in characters.Where(c => c.YearCreated == 1981 && c.Series.Contains("Mario")).Select(c => c.Name))
// {
//     Console.WriteLine($"\t{name}");
// }

// List how many characters were created in 1981 (Donkey Kong series)
// Console.WriteLine($"Donkey Kong series characters created in 1981 - {characters.Count(c => c.YearCreated == 1981 && c.Series.Contains("Donkey Kong"))}");

// Display the characters created in 1981 (Donkey Kong series) name only
// foreach(string? name in characters.Where(c => c.YearCreated == 1981 && c.Series.Contains("Donkey Kong")).Select(c => c.Name))
// {
//     Console.WriteLine($"\t{name}");
// }

// List number of characters were created in Donkey Kong 64
// Console.WriteLine($"Characters first appearing in Donkey Kong 64 - {characters.Count(c => c.FirstAppearance == "Donkey Kong 64")}");

// List them, name only
// foreach(string? name in characters.Where(c => c.FirstAppearance == "Donkey Kong 64").Select(c => c.Name))
// {
//     Console.WriteLine($"\t{name}");
// }

// Any characters without an alias?
// bool aliasLess = characters.Any(c => c.Alias.Count() == 0);
// Console.WriteLine($"Character(s) without an alias = {aliasLess}");

// How many?
// Console.WriteLine($"Number of characters without an alias = {characters.Count(c => c.Alias.Count() == 0)}");

// List the characters without an alias by name, series and alias
// foreach(CharacterDTO characterDTO in characters.Where(c => c.Alias.Count() == 0).Select(c => new CharacterDTO{ Name = c.Name, Series = c.Series, Alias = c.Alias}))
// {
//     Console.WriteLine(characterDTO.Display());
// }

// Any mario series characters with no alias?
// bool MarioAliasLess = characters.Any(c => c.Alias.Count() == 0 && c.Series.Contains("Mario"));
// Console.WriteLine($"Mario series character(s) without an alias = {MarioAliasLess}");

// How many?
// Console.WriteLine($"Number of Mario series characters without an alias = {characters.Count(c => c.Alias.Count() == 0 && c.Series.Contains("Mario"))}");

// List them, name and alias
// foreach(String? name in characters.Where(c => c.Alias.Count() == 0 && c.Series.Contains("Mario")).Select(c => c.Name))
// {
//     Console.WriteLine($"Name: {name}\nAlias:\n");
// }

// are there any characters without an alias in the DK series
// bool DkAliasLess = characters.Any(c => c.Alias.Count() == 0 && c.Series.Contains("Donkey Kong"));
// Console.WriteLine($"Donkey Kong series character(s) without an alias = {DkAliasLess}");

// how many?
// Console.WriteLine($"Number of Donkey Kong series characters without an alias = {characters.Count(c => c.Alias.Count() == 0 && c.Series.Contains("Donkey Kong"))}");

// list them, name and alias
// foreach(String? name in characters.Where(c => c.Alias.Count() == 0 && c.Series.Contains("Donkey Kong")).Select(c => c.Name))
// {
//     Console.WriteLine($"Name: {name}\nAlias:\n");
// }

// does any character have the alias "Snowmad King"?
// bool hasSnowmadKing = characters.Any(c => c.Alias.Contains("Snowmad King"));
// Console.WriteLine($"Alias \"Snowmad King\" exists = {hasSnowmadKing}");

// List name and aliases of the character with the alias "Snowmad King"
// foreach(CharacterDTO characterDTO in characters.Where(c => c.Alias.Contains("Snowmad King")).Select(c => new CharacterDTO{ Name = c.Name, Alias = c.Alias}))
// {
//     Console.WriteLine(characterDTO.Display());
// }

// character has alias "Winter Kong"
// bool hasWinterKong = characters.Any(c => c.Alias.Contains("Winter Kong"));
// Console.WriteLine($"Alias \"Winter Kong\" exists = {hasWinterKong}");

// List name and aliases of the character with the alias "Winter Kong"
// foreach(CharacterDTO characterDTO in characters.Where(c => c.Alias.Contains("Winter Kong")).Select(c => new CharacterDTO{ Name = c.Name, Alias = c.Alias}))
// {
//     Console.WriteLine(characterDTO.Display());
// }

// how many characters with species "Kremling"?
// Console.WriteLine($"Number of characters with species \"Kremling\" = {characters.Count(c => c.Species == "Kremling")}");

// List them name only
foreach(string? name in characters.Where(c => c.Species == "Kremling").Select(c => c.Name))
{
    Console.WriteLine($"{name}");
}