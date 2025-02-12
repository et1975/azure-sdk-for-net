// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.Monitor.OpenTelemetry.Exporter.Models
{
    /// <summary> Instances of Event represent structured event records that can be grouped and searched by their properties. Event data item also creates a metric of event count by name. </summary>
    internal partial class TelemetryEventData : MonitorDomain
    {
        /// <summary> Initializes a new instance of <see cref="TelemetryEventData"/>. </summary>
        /// <param name="version"> Schema version. </param>
        /// <param name="name"> Event name. Keep it low cardinality to allow proper grouping and useful metrics. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public TelemetryEventData(int version, string name) : base(version)
        {
            Argument.AssertNotNull(name, nameof(name));

            Name = name;
            Properties = new ChangeTrackingDictionary<string, string>();
            Measurements = new ChangeTrackingDictionary<string, double>();
        }

        /// <summary> Event name. Keep it low cardinality to allow proper grouping and useful metrics. </summary>
        public string Name { get; }
        /// <summary> Collection of custom properties. </summary>
        public IDictionary<string, string> Properties { get; }
        /// <summary> Collection of custom measurements. </summary>
        public IDictionary<string, double> Measurements { get; }
    }
}
