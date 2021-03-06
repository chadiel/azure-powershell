﻿// ----------------------------------------------------------------------------------
//
// Copyright Microsoft Corporation
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// http://www.apache.org/licenses/LICENSE-2.0
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
// ----------------------------------------------------------------------------------

using System;
using System.Linq;
using System.Management.Automation;
using Microsoft.Azure.Commands.Compute.Common;
using Microsoft.Azure.Commands.Compute.Models;
using Microsoft.WindowsAzure.Commands.Utilities.Common;

namespace Microsoft.Azure.Commands.Compute
{
    /// <summary>
    /// Setup the network interface.
    /// </summary>
    [Cmdlet(
        VerbsCommon.Remove,
        ProfileNouns.NetworkInterface),
    OutputType(
        typeof(PSVirtualMachine))]
    public class RemoveAzureVMNetworkInterfaceCommand : AzurePSCmdlet
    {
        [Alias("VMProfile")]
        [Parameter(
            Mandatory = true,
            Position = 0,
            ValueFromPipeline = true,
            ValueFromPipelineByPropertyName = true,
            HelpMessage = HelpMessages.VMProfile)]
        [ValidateNotNullOrEmpty]
        public PSVirtualMachine VM { get; set; }

        [Alias("Id", "NicIds")]
        [Parameter(
            Mandatory = true,
            Position = 1,
            ValueFromPipelineByPropertyName = true,
            HelpMessage = HelpMessages.VMNetworkInterfaceID)]
        [ValidateNotNullOrEmpty]
        public string[] NetworkInterfaceIDs { get; set; }

        public override void ExecuteCmdlet()
        {
            var networkProfile = this.VM.NetworkProfile;

            foreach (var id in this.NetworkInterfaceIDs)
            {
                if (networkProfile != null &&
                    networkProfile.NetworkInterfaces != null &&
                    networkProfile.NetworkInterfaces.Any(nic =>
                        string.Equals(nic.ReferenceUri, id, StringComparison.OrdinalIgnoreCase)))
                {
                    var nicReference = networkProfile.NetworkInterfaces.First(nic => string.Equals(nic.ReferenceUri, id, StringComparison.OrdinalIgnoreCase));
                    networkProfile.NetworkInterfaces.Remove(nicReference);
                }
            }

            if (!networkProfile.NetworkInterfaces.Any())
            {
                networkProfile = null;
            }

            this.VM.NetworkProfile = networkProfile;

            WriteObject(this.VM);
        }
    }
}
