using System.Text.Json.Serialization;

namespace Soccer.Server.FutDb
{
    public partial class Leagues
    {
        [JsonPropertyName("count")]
        public long Count { get; set; }

        [JsonPropertyName("count_total")]
        public long CountTotal { get; set; }

        [JsonPropertyName("page")]
        public long Page { get; set; }

        [JsonPropertyName("page_total")]
        public long PageTotal { get; set; }

        [JsonPropertyName("items_per_page")]
        public long ItemsPerPage { get; set; }

        [JsonPropertyName("items")]
        public LeagueItem[] Items { get; set; }
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
