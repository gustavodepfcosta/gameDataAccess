using GameDataParser.GameData;

namespace GameDataParser.DataAccess;

public interface IJsonTransform
{
    List<GameDataPattern> TextToJson(string parseable);
}