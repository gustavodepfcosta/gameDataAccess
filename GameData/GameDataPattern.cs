
namespace GameDataParser.GameData;

public class GameDataPattern(
    string title,
    int releaseYear,
    float rating)
{
    public string Title { get; init; } = title;
    public int ReleaseYear { get; init; } = releaseYear;
    public float Rating { get; init; } = rating;
}
