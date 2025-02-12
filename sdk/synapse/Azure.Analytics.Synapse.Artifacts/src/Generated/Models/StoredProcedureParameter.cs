// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    /// <summary> SQL stored procedure parameter. </summary>
    internal partial class StoredProcedureParameter
    {
        /// <summary> Initializes a new instance of <see cref="StoredProcedureParameter"/>. </summary>
        internal StoredProcedureParameter()
        {
        }

        /// <summary> Stored procedure parameter value. Type: string (or Expression with resultType string). </summary>
        public object Value { get; }
        /// <summary> Stored procedure parameter type. </summary>
        public StoredProcedureParameterType? Type { get; }
    }
}
