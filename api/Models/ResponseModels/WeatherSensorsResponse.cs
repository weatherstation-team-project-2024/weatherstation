using System.Text.Json.Serialization;
namespace api.Models
{
    public class WeatherSensorsResponse
    {
        [JsonPropertyName("lsid")]
        public int Lsid { get; set; }

        [JsonPropertyName("data")]
        public List<SensorDataResponse> Data { get; set; } = new List<SensorDataResponse>();
    }
}