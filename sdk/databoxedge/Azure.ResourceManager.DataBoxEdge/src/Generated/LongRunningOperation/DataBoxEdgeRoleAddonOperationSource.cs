// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.ResourceManager;

namespace Azure.ResourceManager.DataBoxEdge
{
    internal class DataBoxEdgeRoleAddonOperationSource : IOperationSource<DataBoxEdgeRoleAddonResource>
    {
        private readonly ArmClient _client;

        internal DataBoxEdgeRoleAddonOperationSource(ArmClient client)
        {
            _client = client;
        }

        DataBoxEdgeRoleAddonResource IOperationSource<DataBoxEdgeRoleAddonResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = DataBoxEdgeRoleAddonData.DeserializeDataBoxEdgeRoleAddonData(document.RootElement);
            return new DataBoxEdgeRoleAddonResource(_client, data);
        }

        async ValueTask<DataBoxEdgeRoleAddonResource> IOperationSource<DataBoxEdgeRoleAddonResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = DataBoxEdgeRoleAddonData.DeserializeDataBoxEdgeRoleAddonData(document.RootElement);
            return new DataBoxEdgeRoleAddonResource(_client, data);
        }
    }
}
