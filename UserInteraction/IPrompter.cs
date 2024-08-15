using GameDataParser.GameData;

namespace GameDataParser.UserInteraction;

public interface IPrompter
{
    string GetUserEntry();
    void ShowGamesInformation(List<GameDataPattern> gamesList);
}