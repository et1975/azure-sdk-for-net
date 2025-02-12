// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.EventGrid.Models
{
    /// <summary> The AlternativeAuthenticationNameSource. </summary>
    public readonly partial struct AlternativeAuthenticationNameSource : IEquatable<AlternativeAuthenticationNameSource>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="AlternativeAuthenticationNameSource"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public AlternativeAuthenticationNameSource(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string ClientCertificateSubjectValue = "ClientCertificateSubject";
        private const string ClientCertificateDnsValue = "ClientCertificateDns";
        private const string ClientCertificateUriValue = "ClientCertificateUri";
        private const string ClientCertificateIPValue = "ClientCertificateIp";
        private const string ClientCertificateEmailValue = "ClientCertificateEmail";

        /// <summary> ClientCertificateSubject. </summary>
        public static AlternativeAuthenticationNameSource ClientCertificateSubject { get; } = new AlternativeAuthenticationNameSource(ClientCertificateSubjectValue);
        /// <summary> ClientCertificateDns. </summary>
        public static AlternativeAuthenticationNameSource ClientCertificateDns { get; } = new AlternativeAuthenticationNameSource(ClientCertificateDnsValue);
        /// <summary> ClientCertificateUri. </summary>
        public static AlternativeAuthenticationNameSource ClientCertificateUri { get; } = new AlternativeAuthenticationNameSource(ClientCertificateUriValue);
        /// <summary> ClientCertificateIp. </summary>
        public static AlternativeAuthenticationNameSource ClientCertificateIP { get; } = new AlternativeAuthenticationNameSource(ClientCertificateIPValue);
        /// <summary> ClientCertificateEmail. </summary>
        public static AlternativeAuthenticationNameSource ClientCertificateEmail { get; } = new AlternativeAuthenticationNameSource(ClientCertificateEmailValue);
        /// <summary> Determines if two <see cref="AlternativeAuthenticationNameSource"/> values are the same. </summary>
        public static bool operator ==(AlternativeAuthenticationNameSource left, AlternativeAuthenticationNameSource right) => left.Equals(right);
        /// <summary> Determines if two <see cref="AlternativeAuthenticationNameSource"/> values are not the same. </summary>
        public static bool operator !=(AlternativeAuthenticationNameSource left, AlternativeAuthenticationNameSource right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="AlternativeAuthenticationNameSource"/>. </summary>
        public static implicit operator AlternativeAuthenticationNameSource(string value) => new AlternativeAuthenticationNameSource(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is AlternativeAuthenticationNameSource other && Equals(other);
        /// <inheritdoc />
        public bool Equals(AlternativeAuthenticationNameSource other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
