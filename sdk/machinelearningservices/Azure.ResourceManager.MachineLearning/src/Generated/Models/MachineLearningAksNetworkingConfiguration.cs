// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary> Advance configuration for AKS networking. </summary>
    public partial class MachineLearningAksNetworkingConfiguration
    {
        /// <summary> Initializes a new instance of <see cref="MachineLearningAksNetworkingConfiguration"/>. </summary>
        public MachineLearningAksNetworkingConfiguration()
        {
        }

        /// <summary> Initializes a new instance of <see cref="MachineLearningAksNetworkingConfiguration"/>. </summary>
        /// <param name="subnetId"> Virtual network subnet resource ID the compute nodes belong to. </param>
        /// <param name="serviceCidr"> A CIDR notation IP range from which to assign service cluster IPs. It must not overlap with any Subnet IP ranges. </param>
        /// <param name="dnsServiceIP"> An IP address assigned to the Kubernetes DNS service. It must be within the Kubernetes service address range specified in serviceCidr. </param>
        /// <param name="dockerBridgeCidr"> A CIDR notation IP range assigned to the Docker bridge network. It must not overlap with any Subnet IP ranges or the Kubernetes service address range. </param>
        internal MachineLearningAksNetworkingConfiguration(ResourceIdentifier subnetId, string serviceCidr, string dnsServiceIP, string dockerBridgeCidr)
        {
            SubnetId = subnetId;
            ServiceCidr = serviceCidr;
            DnsServiceIP = dnsServiceIP;
            DockerBridgeCidr = dockerBridgeCidr;
        }

        /// <summary> Virtual network subnet resource ID the compute nodes belong to. </summary>
        public ResourceIdentifier SubnetId { get; set; }
        /// <summary> A CIDR notation IP range from which to assign service cluster IPs. It must not overlap with any Subnet IP ranges. </summary>
        public string ServiceCidr { get; set; }
        /// <summary> An IP address assigned to the Kubernetes DNS service. It must be within the Kubernetes service address range specified in serviceCidr. </summary>
        public string DnsServiceIP { get; set; }
        /// <summary> A CIDR notation IP range assigned to the Docker bridge network. It must not overlap with any Subnet IP ranges or the Kubernetes service address range. </summary>
        public string DockerBridgeCidr { get; set; }
    }
}
