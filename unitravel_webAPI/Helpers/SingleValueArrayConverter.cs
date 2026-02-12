using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace unitravel_webAPI.Helpers
{
    public class SingleValueArrayConverter<T> : JsonConverter
    {
        public override bool CanConvert(Type objectType)
        {
            return (objectType == typeof(List<T>));
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            JToken token = JToken.Load(reader);

            if (token.Type == JTokenType.Array)
            {
                // Je to pole, standardní chování
                return token.ToObject<List<T>>();
            }

            // Je to objekt (nebo null), zabalíme to do Listu
            if (token.Type == JTokenType.Object)
            {
                return new List<T> { token.ToObject<T>() };
            }

            return new List<T>(); // Null nebo jiný bordel -> prázdný list
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            serializer.Serialize(writer, value);
        }

        public override bool CanWrite => true;
    }
}
