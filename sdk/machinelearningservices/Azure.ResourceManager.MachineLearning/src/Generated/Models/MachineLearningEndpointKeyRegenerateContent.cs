// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary> The MachineLearningEndpointKeyRegenerateContent. </summary>
    public partial class MachineLearningEndpointKeyRegenerateContent
    {
        /// <summary> Initializes a new instance of <see cref="MachineLearningEndpointKeyRegenerateContent"/>. </summary>
        /// <param name="keyType"> [Required] Specification for which type of key to generate. Primary or Secondary. </param>
        public MachineLearningEndpointKeyRegenerateContent(MachineLearningKeyType keyType)
        {
            KeyType = keyType;
        }

        /// <summary> [Required] Specification for which type of key to generate. Primary or Secondary. </summary>
        public MachineLearningKeyType KeyType { get; }
        /// <summary> The value the key is set to. </summary>
        public string KeyValue { get; set; }
    }
}
