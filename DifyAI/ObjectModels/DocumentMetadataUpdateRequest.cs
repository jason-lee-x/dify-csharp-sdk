using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace DifyAI.ObjectModels
{
    public class DocumentMetadataUpdateRequest : RequestBase
    {
        /// <summary>
        /// ID of the metadata
        /// </summary>
        [JsonIgnore]
        public string DatasetId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("operation_data")]
        public List<DocumentMetadataUpdateRequestData> OperationData { get; set; }
    }

    public class DocumentMetadataUpdateRequestData
    {
        /// <summary>
        /// ID of the metadata
        /// </summary>
        [JsonPropertyName("document_id")]
        public string DoucumentId { get; set; }
        /// <summary>
        /// Name of the metadata
        /// </summary>
        [JsonPropertyName("metadata_list")]
        public List<DatasetMetadataValue> MetadataList { get; set; }
    }

   
}
