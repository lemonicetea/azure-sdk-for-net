// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Azure.ResourceManager.Batch.Models
{
    /// <summary> The properties related to the auto-storage account. </summary>
    public partial class BatchAccountAutoStorageBaseConfiguration
    {
        /// <summary> Initializes a new instance of <see cref="BatchAccountAutoStorageBaseConfiguration"/>. </summary>
        /// <param name="storageAccountId"> The resource ID of the storage account to be used for auto-storage account. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="storageAccountId"/> is null. </exception>
        public BatchAccountAutoStorageBaseConfiguration(ResourceIdentifier storageAccountId)
        {
            Argument.AssertNotNull(storageAccountId, nameof(storageAccountId));

            StorageAccountId = storageAccountId;
        }

        /// <summary> Initializes a new instance of <see cref="BatchAccountAutoStorageBaseConfiguration"/>. </summary>
        /// <param name="storageAccountId"> The resource ID of the storage account to be used for auto-storage account. </param>
        /// <param name="authenticationMode"> The authentication mode which the Batch service will use to manage the auto-storage account. </param>
        /// <param name="nodeIdentity"> The identity referenced here must be assigned to pools which have compute nodes that need access to auto-storage. </param>
        internal BatchAccountAutoStorageBaseConfiguration(ResourceIdentifier storageAccountId, BatchAutoStorageAuthenticationMode? authenticationMode, ComputeNodeIdentityReference nodeIdentity)
        {
            StorageAccountId = storageAccountId;
            AuthenticationMode = authenticationMode;
            NodeIdentity = nodeIdentity;
        }

        /// <summary> The resource ID of the storage account to be used for auto-storage account. </summary>
        public ResourceIdentifier StorageAccountId { get; set; }
        /// <summary> The authentication mode which the Batch service will use to manage the auto-storage account. </summary>
        public BatchAutoStorageAuthenticationMode? AuthenticationMode { get; set; }
        /// <summary> The identity referenced here must be assigned to pools which have compute nodes that need access to auto-storage. </summary>
        internal ComputeNodeIdentityReference NodeIdentity { get; set; }
        /// <summary> The ARM resource id of the user assigned identity. </summary>
        public ResourceIdentifier NodeIdentityResourceId
        {
            get => NodeIdentity is null ? default : NodeIdentity.ResourceId;
            set
            {
                if (NodeIdentity is null)
                    NodeIdentity = new ComputeNodeIdentityReference();
                NodeIdentity.ResourceId = value;
            }
        }
    }
}
