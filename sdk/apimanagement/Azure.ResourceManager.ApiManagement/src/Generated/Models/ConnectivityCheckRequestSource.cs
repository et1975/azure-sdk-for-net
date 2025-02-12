// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Azure.ResourceManager.ApiManagement.Models
{
    /// <summary> Definitions about the connectivity check origin. </summary>
    public partial class ConnectivityCheckRequestSource
    {
        /// <summary> Initializes a new instance of <see cref="ConnectivityCheckRequestSource"/>. </summary>
        /// <param name="region"> The API Management service region from where to start the connectivity check operation. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="region"/> is null. </exception>
        public ConnectivityCheckRequestSource(string region)
        {
            Argument.AssertNotNull(region, nameof(region));

            Region = region;
        }

        /// <summary> The API Management service region from where to start the connectivity check operation. </summary>
        public string Region { get; }
        /// <summary> The particular VMSS instance from which to fire the request. </summary>
        public long? Instance { get; set; }
    }
}
