// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.ManagedNetworkFabric.Models
{
    /// <summary> OptionB Layer3 Configuration properties. </summary>
    public partial class OptionBLayer3Configuration : Layer3IPPrefixProperties
    {
        /// <summary> Initializes a new instance of <see cref="OptionBLayer3Configuration"/>. </summary>
        public OptionBLayer3Configuration()
        {
        }

        /// <summary> Initializes a new instance of <see cref="OptionBLayer3Configuration"/>. </summary>
        /// <param name="primaryIPv4Prefix"> IPv4 Address Prefix. </param>
        /// <param name="primaryIPv6Prefix"> IPv6 Address Prefix. </param>
        /// <param name="secondaryIPv4Prefix"> Secondary IPv4 Address Prefix. </param>
        /// <param name="secondaryIPv6Prefix"> Secondary IPv6 Address Prefix. </param>
        /// <param name="peerAsn"> ASN of PE devices for CE/PE connectivity.Example : 28. </param>
        /// <param name="vlanId"> VLAN for CE/PE Layer 3 connectivity.Example : 501. </param>
        /// <param name="fabricAsn"> ASN of CE devices for CE/PE connectivity. </param>
        internal OptionBLayer3Configuration(string primaryIPv4Prefix, string primaryIPv6Prefix, string secondaryIPv4Prefix, string secondaryIPv6Prefix, long? peerAsn, int? vlanId, long? fabricAsn) : base(primaryIPv4Prefix, primaryIPv6Prefix, secondaryIPv4Prefix, secondaryIPv6Prefix)
        {
            PeerAsn = peerAsn;
            VlanId = vlanId;
            FabricAsn = fabricAsn;
        }

        /// <summary> ASN of PE devices for CE/PE connectivity.Example : 28. </summary>
        public long? PeerAsn { get; set; }
        /// <summary> VLAN for CE/PE Layer 3 connectivity.Example : 501. </summary>
        public int? VlanId { get; set; }
        /// <summary> ASN of CE devices for CE/PE connectivity. </summary>
        public long? FabricAsn { get; }
    }
}
