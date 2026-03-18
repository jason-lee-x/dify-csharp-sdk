using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace DifyAI.ObjectModels
{
    public class DatasetMetadataUpdateRequest : DatasetMetadataCreateRequest
    {
        /// <summary>
        /// ID of the metadata
        /// </summary>
        [JsonIgnore]
        public string MetadataId { get; set; }
    }
}
