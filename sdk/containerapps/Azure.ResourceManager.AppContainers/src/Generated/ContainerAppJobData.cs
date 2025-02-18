// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.AppContainers.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.AppContainers
{
    /// <summary>
    /// A class representing the ContainerAppJob data model.
    /// Container App Job
    /// </summary>
    public partial class ContainerAppJobData : TrackedResourceData
    {
        /// <summary> Initializes a new instance of <see cref="ContainerAppJobData"/>. </summary>
        /// <param name="location"> The location. </param>
        public ContainerAppJobData(AzureLocation location) : base(location)
        {
            OutboundIPAddresses = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of <see cref="ContainerAppJobData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="identity"> Managed identities needed by a container app job to interact with other Azure services to not maintain any secrets or credentials in code. </param>
        /// <param name="provisioningState"> Provisioning state of the Container Apps Job. </param>
        /// <param name="environmentId"> Resource ID of environment. </param>
        /// <param name="workloadProfileName"> Workload profile name to pin for container apps job execution. </param>
        /// <param name="configuration"> Container Apps Job configuration properties. </param>
        /// <param name="template"> Container Apps job definition. </param>
        /// <param name="outboundIPAddresses"> Outbound IP Addresses of a container apps job. </param>
        /// <param name="eventStreamEndpoint"> The endpoint of the eventstream of the container apps job. </param>
        internal ContainerAppJobData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, IDictionary<string, string> tags, AzureLocation location, ManagedServiceIdentity identity, ContainerAppJobProvisioningState? provisioningState, string environmentId, string workloadProfileName, ContainerAppJobConfiguration configuration, ContainerAppJobTemplate template, IReadOnlyList<string> outboundIPAddresses, string eventStreamEndpoint) : base(id, name, resourceType, systemData, tags, location)
        {
            Identity = identity;
            ProvisioningState = provisioningState;
            EnvironmentId = environmentId;
            WorkloadProfileName = workloadProfileName;
            Configuration = configuration;
            Template = template;
            OutboundIPAddresses = outboundIPAddresses;
            EventStreamEndpoint = eventStreamEndpoint;
        }

        /// <summary> Managed identities needed by a container app job to interact with other Azure services to not maintain any secrets or credentials in code. </summary>
        public ManagedServiceIdentity Identity { get; set; }
        /// <summary> Provisioning state of the Container Apps Job. </summary>
        public ContainerAppJobProvisioningState? ProvisioningState { get; }
        /// <summary> Resource ID of environment. </summary>
        public string EnvironmentId { get; set; }
        /// <summary> Workload profile name to pin for container apps job execution. </summary>
        public string WorkloadProfileName { get; set; }
        /// <summary> Container Apps Job configuration properties. </summary>
        public ContainerAppJobConfiguration Configuration { get; set; }
        /// <summary> Container Apps job definition. </summary>
        public ContainerAppJobTemplate Template { get; set; }
        /// <summary> Outbound IP Addresses of a container apps job. </summary>
        public IReadOnlyList<string> OutboundIPAddresses { get; }
        /// <summary> The endpoint of the eventstream of the container apps job. </summary>
        public string EventStreamEndpoint { get; }
    }
}
