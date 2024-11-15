using System.Text.Json.Serialization;

namespace EntityFramework.models{
    public class Computer{
        [JsonPropertyName("computer_id")]
        public int ComputerId {get;set;}
        [JsonPropertyName("os")]
        public string Os{get;set;}= "";
        [JsonPropertyName("cpu_cores")]

        public int CPUCores {get;set;}
        [JsonPropertyName("release_date")]
        public DateTime ReleaseDate {get;set;}
        [JsonPropertyName("has_wifi")]

        public bool HasWifi {get;set;}
        [JsonPropertyName("memory_space")]
        public decimal MemorySpace {get;set;}


    }
}