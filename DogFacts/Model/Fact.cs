using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace DogFacts.Model
{
    // Root myDeserializedClass = JsonSerializer.Deserialize<Root>(myJsonResponse);
    public class Facts
    {
        [JsonPropertyName("facts")]
        public List<string> Fact { get; set; }

        [JsonPropertyName("success")]
        public bool Success { get; set; }
    }


}
