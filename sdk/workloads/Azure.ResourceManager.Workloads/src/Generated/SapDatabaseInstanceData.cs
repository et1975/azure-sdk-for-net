// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Resources.Models;
using Azure.ResourceManager.Workloads.Models;

namespace Azure.ResourceManager.Workloads
{
    /// <summary>
    /// A class representing the SapDatabaseInstance data model.
    /// Define the Database resource.
    /// </summary>
    public partial class SapDatabaseInstanceData : TrackedResourceData
    {
        /// <summary> Initializes a new instance of <see cref="SapDatabaseInstanceData"/>. </summary>
        /// <param name="location"> The location. </param>
        public SapDatabaseInstanceData(AzureLocation location) : base(location)
        {
            VmDetails = new ChangeTrackingList<DatabaseVmDetails>();
        }

        /// <summary> Initializes a new instance of <see cref="SapDatabaseInstanceData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="subnetId"> Database subnet. </param>
        /// <param name="databaseSid"> Database SID name. </param>
        /// <param name="databaseType"> Database type, that is if the DB is HANA, DB2, Oracle, SAP ASE, Max DB or MS SQL Server. </param>
        /// <param name="ipAddress"> Database IP Address. </param>
        /// <param name="loadBalancerDetails"> The Load Balancer details such as LoadBalancer ID attached to Database Virtual Machines. </param>
        /// <param name="vmDetails"> The list of virtual machines corresponding to the Database resource. </param>
        /// <param name="status"> Defines the SAP Instance status. </param>
        /// <param name="provisioningState"> Defines the provisioning states. </param>
        /// <param name="errors"> Defines the errors related to Database resource. </param>
        internal SapDatabaseInstanceData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, IDictionary<string, string> tags, AzureLocation location, ResourceIdentifier subnetId, string databaseSid, string databaseType, string ipAddress, SubResource loadBalancerDetails, IReadOnlyList<DatabaseVmDetails> vmDetails, SapVirtualInstanceStatus? status, SapVirtualInstanceProvisioningState? provisioningState, SapVirtualInstanceError errors) : base(id, name, resourceType, systemData, tags, location)
        {
            SubnetId = subnetId;
            DatabaseSid = databaseSid;
            DatabaseType = databaseType;
            IPAddress = ipAddress;
            LoadBalancerDetails = loadBalancerDetails;
            VmDetails = vmDetails;
            Status = status;
            ProvisioningState = provisioningState;
            Errors = errors;
        }

        /// <summary> Database subnet. </summary>
        public ResourceIdentifier SubnetId { get; }
        /// <summary> Database SID name. </summary>
        public string DatabaseSid { get; }
        /// <summary> Database type, that is if the DB is HANA, DB2, Oracle, SAP ASE, Max DB or MS SQL Server. </summary>
        public string DatabaseType { get; }
        /// <summary> Database IP Address. </summary>
        public string IPAddress { get; }
        /// <summary> The Load Balancer details such as LoadBalancer ID attached to Database Virtual Machines. </summary>
        internal SubResource LoadBalancerDetails { get; }
        /// <summary> Gets Id. </summary>
        public ResourceIdentifier LoadBalancerDetailsId
        {
            get => LoadBalancerDetails?.Id;
        }

        /// <summary> The list of virtual machines corresponding to the Database resource. </summary>
        public IReadOnlyList<DatabaseVmDetails> VmDetails { get; }
        /// <summary> Defines the SAP Instance status. </summary>
        public SapVirtualInstanceStatus? Status { get; }
        /// <summary> Defines the provisioning states. </summary>
        public SapVirtualInstanceProvisioningState? ProvisioningState { get; }
        /// <summary> Defines the errors related to Database resource. </summary>
        internal SapVirtualInstanceError Errors { get; }
        /// <summary> The Virtual Instance for SAP error body. </summary>
        public SapVirtualInstanceErrorDetail ErrorsProperties
        {
            get => Errors?.Properties;
        }
    }
}
