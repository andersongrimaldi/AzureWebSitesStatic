using System.Text.Json.Serialization;

namespace Soccer.Shared.FutDb
{
	public class PageFutModel
	{
        [JsonPropertyName("count")]
        public int Count { get; set; }

        [JsonPropertyName("count_total")]
        public int CountTotal { get; set; }

        [JsonPropertyName("page")]
        public int Page { get; set; }

        [JsonPropertyName("page_total")]
        public int PageTotal { get; set; }

        [JsonPropertyName("items_per_page")]
        public int ItemsPerPage { get; set; }
    }
}
