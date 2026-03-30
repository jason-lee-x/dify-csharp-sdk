using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace DifyAI.ObjectModels
{
    public class DatasetMetadataValue
    {
        /// <summary>
        /// ID of the metadata
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; }
        /// <summary>
        /// Name of the metadata
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// Value of the metadata
        /// </summary>
        [JsonPropertyName("value")]
        public string Value { get; set; }
    }
}
