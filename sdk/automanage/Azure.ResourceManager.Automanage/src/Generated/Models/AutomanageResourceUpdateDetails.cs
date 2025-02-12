// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Automanage.Models
{
    /// <summary> Represents an update resource. </summary>
    public partial class AutomanageResourceUpdateDetails
    {
        /// <summary> Initializes a new instance of <see cref="AutomanageResourceUpdateDetails"/>. </summary>
        public AutomanageResourceUpdateDetails()
        {
            Tags = new ChangeTrackingDictionary<string, string>();
        }

        /// <summary> The tags of the resource. </summary>
        public IDictionary<string, string> Tags { get; }
    }
}
