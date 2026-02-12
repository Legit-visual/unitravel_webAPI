using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace unitravel_webAPI.Helpers
{
    public class DebugTboConverter : JsonConverter
    {
        public override bool CanConvert(Type objectType) => true;

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            string path = reader.Path;

            try
            {
                var token = JToken.Load(reader);
                if (objectType == typeof(Dictionary<string, string>))
                {
                    var dict = new Dictionary<string, string>();
                    if (token.Type == JTokenType.Object)
                    {
                        return token.ToObject<Dictionary<string, string>>() ?? dict;
                    }
                    if (token.Type == JTokenType.Array)
                    {
                        int i = 1;
                        foreach (var item in token)
                        {
                            dict[$"{i})"] = item.ToString();
                            i++;
                        }
                        return dict;
                    }
                    return dict;
                }

                if (objectType == typeof(List<string>))
                {
                    var list = new List<string>();
                    if (token.Type == JTokenType.Array)
                    {
                        return token.ToObject<List<string>>() ?? list;
                    }
                    if (token.Type == JTokenType.Object)
                    {
                        return token.Values<string>().ToList();
                    }
                    return list;
                }

                return null;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"[CRITICAL PARSE ERROR] Path: {path} | Error: {ex.Message}");
                // Vracíme prázdný objekt, aby proces pokračoval dál a neshodil zbytek
                return objectType == typeof(List<string>) ? new List<string>() : new Dictionary<string, string>();
            }
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            serializer.Serialize(writer, value);
        }
    }
}
