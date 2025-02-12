// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.ApiManagement.Models
{
    /// <summary> Describes scaling information of a SKU. </summary>
    public partial class ApiManagementSkuCapacity
    {
        /// <summary> Initializes a new instance of <see cref="ApiManagementSkuCapacity"/>. </summary>
        internal ApiManagementSkuCapacity()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ApiManagementSkuCapacity"/>. </summary>
        /// <param name="minimum"> The minimum capacity. </param>
        /// <param name="maximum"> The maximum capacity that can be set. </param>
        /// <param name="default"> The default capacity. </param>
        /// <param name="scaleType"> The scale type applicable to the sku. </param>
        internal ApiManagementSkuCapacity(int? minimum, int? maximum, int? @default, ApiManagementSkuCapacityScaleType? scaleType)
        {
            Minimum = minimum;
            Maximum = maximum;
            Default = @default;
            ScaleType = scaleType;
        }

        /// <summary> The minimum capacity. </summary>
        public int? Minimum { get; }
        /// <summary> The maximum capacity that can be set. </summary>
        public int? Maximum { get; }
        /// <summary> The default capacity. </summary>
        public int? Default { get; }
        /// <summary> The scale type applicable to the sku. </summary>
        public ApiManagementSkuCapacityScaleType? ScaleType { get; }
    }
}
