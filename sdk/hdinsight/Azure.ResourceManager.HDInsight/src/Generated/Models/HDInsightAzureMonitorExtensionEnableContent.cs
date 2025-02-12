// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.HDInsight.Models
{
    /// <summary> The azure monitor parameters. </summary>
    public partial class HDInsightAzureMonitorExtensionEnableContent
    {
        /// <summary> Initializes a new instance of <see cref="HDInsightAzureMonitorExtensionEnableContent"/>. </summary>
        public HDInsightAzureMonitorExtensionEnableContent()
        {
        }

        /// <summary> The Log Analytics workspace ID. </summary>
        public string WorkspaceId { get; set; }
        /// <summary> The Log Analytics workspace key. </summary>
        public string PrimaryKey { get; set; }
        /// <summary> The selected configurations. </summary>
        public HDInsightAzureMonitorSelectedConfigurations SelectedConfigurations { get; set; }
    }
}
