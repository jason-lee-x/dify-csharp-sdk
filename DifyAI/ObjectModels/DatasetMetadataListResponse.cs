using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace DifyAI.ObjectModels
{
    public class DatasetMetadataListResponse : ResponseBase
    {
        /// <summary>
        /// ID of the metadata
        /// </summary>
        [JsonPropertyName("doc_metadata")]
        public List<DatasetMetadata> DocMetadata { get; set; }

        /// <summary>
        /// Binding count of the metadata
        /// </summary>
        [JsonPropertyName("built_in_field_enabled")]
        public bool BuiltinFieldEnabled { get; set; }
    }
}
