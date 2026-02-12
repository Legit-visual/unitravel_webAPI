namespace unitravel_webAPI.Helpers
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;
    using System;
    using System.Collections.Generic;
    using System.Linq;

    namespace unitravel_webAPI.Helpers // Nebo váš namespace
    {
        // Konvertor pro HotelFacilities: Bere Pole i Objekt a vrací List<string>
        public class TboFacilitiesConverter : JsonConverter
        {
            public override bool CanConvert(Type objectType) => true;

            public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
            {
                var token = JToken.Load(reader);

                if (token.Type == JTokenType.Array)
                {
                    return token.ToObject<List<string>>();
                }
                if (token.Type == JTokenType.Object)
                {
                    // Pokud je to objekt, vezmeme jeho hodnoty jako stringy
                    return token.Values<string>().ToList();
                }
                return new List<string>();
            }

            public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
            {
                // Při zápisu (pro PHP) to pošleme vždy jako pole stringů
                serializer.Serialize(writer, value);
            }
        }

        // Konvertor pro Attractions: Bere Pole i Objekt a vrací Dictionary
        public class TboAttractionsConverter : JsonConverter
        {
            public override bool CanConvert(Type objectType) => true;

            public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
            {
                var token = JToken.Load(reader);
                var dict = new Dictionary<string, string>();

                if (token.Type == JTokenType.Object)
                {
                    try { return token.ToObject<Dictionary<string, string>>(); }
                    catch { return dict; }
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

            public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
            {
                serializer.Serialize(writer, value);
            }
        }
    }
}
