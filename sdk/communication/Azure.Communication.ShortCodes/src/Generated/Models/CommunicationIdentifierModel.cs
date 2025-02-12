// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.Communication.ShortCodes.Models
{
    /// <summary> Identifies a participant in Azure Communication services. A participant is, for example, a phone number or an Azure communication user. This model must be interpreted as a union: Apart from rawId, at most one further property may be set. </summary>
    internal partial class CommunicationIdentifierModel
    {
        /// <summary> Initializes a new instance of <see cref="CommunicationIdentifierModel"/>. </summary>
        internal CommunicationIdentifierModel()
        {
        }

        /// <summary> Raw Id of the identifier. Optional in requests, required in responses. </summary>
        public string RawId { get; }
        /// <summary> The communication user. </summary>
        public CommunicationUserIdentifierModel CommunicationUser { get; }
        /// <summary> The phone number. </summary>
        public PhoneNumberIdentifierModel PhoneNumber { get; }
        /// <summary> The Microsoft Teams user. </summary>
        public MicrosoftTeamsUserIdentifierModel MicrosoftTeamsUser { get; }
    }
}
