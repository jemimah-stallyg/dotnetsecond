using System.Text.Json.Serialization;

namespace dotnet3.rpg.Models
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum RpgClass
    {
        Knight,
        Mage,
        Claric
    }
}