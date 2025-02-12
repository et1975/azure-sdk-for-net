// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.HybridContainerService.Models
{
    /// <summary> The profile of an orchestrator and its available versions. </summary>
    public partial class OrchestratorVersionProfile
    {
        /// <summary> Initializes a new instance of <see cref="OrchestratorVersionProfile"/>. </summary>
        internal OrchestratorVersionProfile()
        {
            Upgrades = new ChangeTrackingList<OrchestratorProfile>();
        }

        /// <summary> Initializes a new instance of <see cref="OrchestratorVersionProfile"/>. </summary>
        /// <param name="isPreview"> Whether Kubernetes version is currently in preview. </param>
        /// <param name="default"> Installed by default if version is not specified. </param>
        /// <param name="orchestratorType"> Orchestrator type. </param>
        /// <param name="orchestratorVersion"> Orchestrator version major.minor.patch, for example 1.21.9. </param>
        /// <param name="upgrades"> The list of available upgrade versions. </param>
        internal OrchestratorVersionProfile(bool? isPreview, bool? @default, string orchestratorType, string orchestratorVersion, IReadOnlyList<OrchestratorProfile> upgrades)
        {
            IsPreview = isPreview;
            Default = @default;
            OrchestratorType = orchestratorType;
            OrchestratorVersion = orchestratorVersion;
            Upgrades = upgrades;
        }

        /// <summary> Whether Kubernetes version is currently in preview. </summary>
        public bool? IsPreview { get; }
        /// <summary> Installed by default if version is not specified. </summary>
        public bool? Default { get; }
        /// <summary> Orchestrator type. </summary>
        public string OrchestratorType { get; }
        /// <summary> Orchestrator version major.minor.patch, for example 1.21.9. </summary>
        public string OrchestratorVersion { get; }
        /// <summary> The list of available upgrade versions. </summary>
        public IReadOnlyList<OrchestratorProfile> Upgrades { get; }
    }
}
