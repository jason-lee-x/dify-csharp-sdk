using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace DifyAI.ObjectModels
{
    public class DatasetMetadataBuiltIn
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// Data type of the dataset
        /// </summary>
        [JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
