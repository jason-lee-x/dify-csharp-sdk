using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace DifyAI.ObjectModels
{
    public class DatasetMetadata : DatasetMetadataBuiltIn
    {
        /// <summary>
        /// ID of the metadata
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; }

        /// <summary>
        /// Binding count of the metadata
        /// </summary>
        [JsonPropertyName("count")]
        public int Count { get; set; }
    }
}
