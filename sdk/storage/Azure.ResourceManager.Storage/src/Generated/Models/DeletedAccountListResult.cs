// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Storage;

namespace Azure.ResourceManager.Storage.Models
{
    /// <summary> The response from the List Deleted Accounts operation. </summary>
    internal partial class DeletedAccountListResult
    {
        /// <summary> Initializes a new instance of <see cref="DeletedAccountListResult"/>. </summary>
        internal DeletedAccountListResult()
        {
            Value = new ChangeTrackingList<DeletedAccountData>();
        }

        /// <summary> Initializes a new instance of <see cref="DeletedAccountListResult"/>. </summary>
        /// <param name="value"> Gets the list of deleted accounts and their properties. </param>
        /// <param name="nextLink"> Request URL that can be used to query next page of deleted accounts. Returned when total number of requested deleted accounts exceed maximum page size. </param>
        internal DeletedAccountListResult(IReadOnlyList<DeletedAccountData> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> Gets the list of deleted accounts and their properties. </summary>
        public IReadOnlyList<DeletedAccountData> Value { get; }
        /// <summary> Request URL that can be used to query next page of deleted accounts. Returned when total number of requested deleted accounts exceed maximum page size. </summary>
        public string NextLink { get; }
    }
}
