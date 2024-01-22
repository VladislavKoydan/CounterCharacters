using CountCharacters;

Console.Write("Enter the string : ");
string input = Console.ReadLine();

CharacterCounter characterCounter = new CharacterCounter(input);

Dictionary<char, int> dict = characterCounter.StringCounter();

foreach (var item in dict.Keys)
{
    Console.WriteLine(item + " : " + dict[item]);
}

