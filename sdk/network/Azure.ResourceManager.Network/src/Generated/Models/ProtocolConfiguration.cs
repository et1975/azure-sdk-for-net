// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> Configuration of the protocol. </summary>
    internal partial class ProtocolConfiguration
    {
        /// <summary> Initializes a new instance of <see cref="ProtocolConfiguration"/>. </summary>
        public ProtocolConfiguration()
        {
        }

        /// <summary> HTTP configuration of the connectivity check. </summary>
        public NetworkHttpConfiguration HttpProtocolConfiguration { get; set; }
    }
}
