using GameDataParser.GameData;

namespace GameDataParser.UserInteraction;

public class Prompter : IPrompter
{
    public string GetUserEntry()
    {
        string userInput = Console.ReadLine() ?? "";

        return userInput;
    }

    public void ShowGamesInformation(List<GameDataPattern> gamesList)
    {
        foreach (var game in gamesList)
        {
            Console.WriteLine("---=---=---=---=---=---=");
            Console.WriteLine($"Title: {game.Title}");
            Console.WriteLine($"ReleaseYear: {game.ReleaseYear}");
            Console.WriteLine($"Rating: {game.Rating}");
            Console.WriteLine("---=---=---=---=---=---=");
        }
    }
}