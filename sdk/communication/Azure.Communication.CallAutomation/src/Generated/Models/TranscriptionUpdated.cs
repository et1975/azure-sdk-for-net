// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.Communication.CallAutomation
{
    /// <summary> The TranscriptionUpdated. </summary>
    internal partial class TranscriptionUpdated
    {
        /// <summary> Initializes a new instance of <see cref="TranscriptionUpdated"/>. </summary>
        internal TranscriptionUpdated()
        {
        }

        /// <summary> Used by customers when calling mid-call actions to correlate the request to the response event. </summary>
        public string OperationContext { get; }
        /// <summary> Contains the resulting SIP code, sub-code and message. </summary>
        public ResultInformation ResultInformation { get; }
        /// <summary> Defines the result for TranscriptionUpdate with the current status and the details about the status. </summary>
        public TranscriptionUpdate TranscriptionUpdate { get; }
        /// <summary> Call connection ID. </summary>
        public string CallConnectionId { get; }
        /// <summary> Server call ID. </summary>
        public string ServerCallId { get; }
        /// <summary> Correlation ID for event to call correlation. Also called ChainId for skype chain ID. </summary>
        public string CorrelationId { get; }
    }
}
