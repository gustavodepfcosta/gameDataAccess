using GameDataParser.GameData;
using System.Text.Json;

namespace GameDataParser.DataAccess;

public class JsonTransform : IJsonTransform
{
    public List<GameDataPattern> TextToJson(string parseable)
    {
        try
        {
            var gamesList = JsonSerializer.Deserialize<List<GameDataPattern>>(parseable);

            return gamesList!;
        }
        catch (ArgumentNullException exception)
        {
            throw new ArgumentNullException("ArgumentNullException", exception);
        }        
        catch (JsonException exception)
        {
            throw new JsonException("JsonException", exception);
        }        
        catch (NotSupportedException exception)
        {
            throw new NotSupportedException("NotSupportedException", exception);
        }
    }
}
