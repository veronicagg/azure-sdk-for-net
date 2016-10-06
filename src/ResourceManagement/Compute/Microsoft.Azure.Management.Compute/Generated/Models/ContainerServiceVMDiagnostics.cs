// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.16.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Compute.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Microsoft.Rest.Azure;

    /// <summary>
    /// Describes VM Diagnostics.
    /// </summary>
    public partial class ContainerServiceVMDiagnostics
    {
        /// <summary>
        /// Initializes a new instance of the ContainerServiceVMDiagnostics
        /// class.
        /// </summary>
        public ContainerServiceVMDiagnostics() { }

        /// <summary>
        /// Initializes a new instance of the ContainerServiceVMDiagnostics
        /// class.
        /// </summary>
        public ContainerServiceVMDiagnostics(bool? enabled = default(bool?), string storageUri = default(string))
        {
            Enabled = enabled;
            StorageUri = storageUri;
        }

        /// <summary>
        /// whether VM Diagnostic Agent should be provisioned on the Virtual
        /// Machine.
        /// </summary>
        [JsonProperty(PropertyName = "enabled")]
        public bool? Enabled { get; set; }

        /// <summary>
        /// whether VM Diagnostic Agent should be provisioned on the Virtual
        /// Machine.
        /// </summary>
        [JsonProperty(PropertyName = "storageUri")]
        public string StorageUri { get; private set; }

    }
}