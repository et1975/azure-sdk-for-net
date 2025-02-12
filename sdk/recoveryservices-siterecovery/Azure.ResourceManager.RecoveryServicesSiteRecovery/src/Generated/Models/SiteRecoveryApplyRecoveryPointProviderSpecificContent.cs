// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    /// <summary>
    /// Provider specific input for apply recovery point.
    /// Please note <see cref="SiteRecoveryApplyRecoveryPointProviderSpecificContent"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
    /// The available derived classes include <see cref="A2AApplyRecoveryPointContent"/>, <see cref="A2ACrossClusterMigrationApplyRecoveryPointContent"/>, <see cref="HyperVReplicaAzureApplyRecoveryPointContent"/>, <see cref="InMageAzureV2ApplyRecoveryPointContent"/> and <see cref="InMageRcmApplyRecoveryPointContent"/>.
    /// </summary>
    public abstract partial class SiteRecoveryApplyRecoveryPointProviderSpecificContent
    {
        /// <summary> Initializes a new instance of <see cref="SiteRecoveryApplyRecoveryPointProviderSpecificContent"/>. </summary>
        protected SiteRecoveryApplyRecoveryPointProviderSpecificContent()
        {
        }

        /// <summary> The class type. </summary>
        internal string InstanceType { get; set; }
    }
}
