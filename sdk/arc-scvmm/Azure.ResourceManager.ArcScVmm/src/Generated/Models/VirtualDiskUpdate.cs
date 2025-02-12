// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.ArcScVmm.Models
{
    /// <summary> Virtual disk model. </summary>
    public partial class VirtualDiskUpdate
    {
        /// <summary> Initializes a new instance of <see cref="VirtualDiskUpdate"/>. </summary>
        public VirtualDiskUpdate()
        {
        }

        /// <summary> Gets or sets the name of the disk. </summary>
        public string Name { get; set; }
        /// <summary> Gets or sets the disk id. </summary>
        public string DiskId { get; set; }
        /// <summary> Gets or sets the disk total size. </summary>
        public int? DiskSizeGB { get; set; }
        /// <summary> Gets or sets the disk bus. </summary>
        public int? Bus { get; set; }
        /// <summary> Gets or sets the disk lun. </summary>
        public int? Lun { get; set; }
        /// <summary> Gets or sets the disk bus type. </summary>
        public string BusType { get; set; }
        /// <summary> Gets or sets the disk vhd type. </summary>
        public string VhdType { get; set; }
        /// <summary> The QoS policy for the disk. </summary>
        public StorageQoSPolicyDetails StorageQoSPolicy { get; set; }
    }
}
