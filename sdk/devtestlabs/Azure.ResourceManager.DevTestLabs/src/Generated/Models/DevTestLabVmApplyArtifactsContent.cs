// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.DevTestLabs.Models
{
    /// <summary> Request body for applying artifacts to a virtual machine. </summary>
    public partial class DevTestLabVmApplyArtifactsContent
    {
        /// <summary> Initializes a new instance of <see cref="DevTestLabVmApplyArtifactsContent"/>. </summary>
        public DevTestLabVmApplyArtifactsContent()
        {
            Artifacts = new ChangeTrackingList<DevTestLabArtifactInstallInfo>();
        }

        /// <summary> The list of artifacts to apply. </summary>
        public IList<DevTestLabArtifactInstallInfo> Artifacts { get; }
    }
}
