using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace DifyAI.ObjectModels
{
    public class DatasetMetadataBuiltInListResponse : ResponseBase
    {
        /// <summary>
        /// ID of the metadata
        /// </summary>
        [JsonPropertyName("fields")]
        public List<DatasetMetadataBuiltIn> Fileds { get; set; }
    }
}
