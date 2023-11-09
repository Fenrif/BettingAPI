using System.ComponentModel;
using System.Text.Json.Serialization;

namespace BettingAPI.Enums
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum Sport
    {
        Football = 1,
        Basketball = 2
    }

    public enum OddSpecifier
    {
        [Description("1")]
        One = 1,
        [Description("2")]
        Two = 2,
        [Description("X")]
        X = 3
    }
}