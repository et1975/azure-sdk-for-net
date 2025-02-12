// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Net;

namespace Azure.ResourceManager.DataLakeAnalytics.Models
{
    /// <summary>
    /// The parameters used to update a firewall rule.
    /// Serialized Name: UpdateFirewallRuleParameters
    /// </summary>
    public partial class DataLakeAnalyticsFirewallRulePatch
    {
        /// <summary> Initializes a new instance of <see cref="DataLakeAnalyticsFirewallRulePatch"/>. </summary>
        public DataLakeAnalyticsFirewallRulePatch()
        {
        }

        /// <summary>
        /// The start IP address for the firewall rule. This can be either ipv4 or ipv6. Start and End should be in the same protocol.
        /// Serialized Name: UpdateFirewallRuleParameters.properties.startIpAddress
        /// </summary>
        public IPAddress StartIPAddress { get; set; }
        /// <summary>
        /// The end IP address for the firewall rule. This can be either ipv4 or ipv6. Start and End should be in the same protocol.
        /// Serialized Name: UpdateFirewallRuleParameters.properties.endIpAddress
        /// </summary>
        public IPAddress EndIPAddress { get; set; }
    }
}
