using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace DifyAI.ObjectModels
{
    public class DatasetMetadataListRequest : RequestBase
    {
        /// <summary>
        /// ID of the dataset
        /// </summary>
        [JsonIgnore]
        public string DatasetId { get; set; }
    }
}
