// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;

namespace Azure.ResourceManager.ContainerRegistry.Models
{
    /// <summary> The parameters for updating a token. </summary>
    public partial class ContainerRegistryTokenPatch
    {
        /// <summary> Initializes a new instance of <see cref="ContainerRegistryTokenPatch"/>. </summary>
        public ContainerRegistryTokenPatch()
        {
        }

        /// <summary> The resource ID of the scope map to which the token will be associated with. </summary>
        public ResourceIdentifier ScopeMapId { get; set; }
        /// <summary> The status of the token example enabled or disabled. </summary>
        public ContainerRegistryTokenStatus? Status { get; set; }
        /// <summary> The credentials that can be used for authenticating the token. </summary>
        public ContainerRegistryTokenCredentials Credentials { get; set; }
    }
}
