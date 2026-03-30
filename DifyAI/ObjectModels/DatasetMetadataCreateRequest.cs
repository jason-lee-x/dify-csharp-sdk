using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace DifyAI.ObjectModels
{
    public class DatasetMetadataCreateRequest : RequestBase
    {
        /// <summary>
        /// ID of the dataset
        /// </summary>
        [JsonIgnore]
        public string DatasetId { get; set; }
        /// <summary>
        /// Name of the metadata
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// Data type of the dataset
        /// </summary>
        [JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
