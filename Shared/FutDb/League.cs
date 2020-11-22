using System.Text.Json.Serialization;

namespace Soccer.Shared.FutDb
{
    public class Leagues : PageFutModel
    {
        [JsonPropertyName("items")]
        public LeagueItem[] LeagueList { get; set; }
    }

    public partial class LeagueItem
    {
        [JsonPropertyName("id")]
        public long Id { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        public byte[] Image { get; set; }
    }
}
