// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Management.Compute.Models
{
    public partial class VirtualMachineExtensionsListResult
    {
        internal static VirtualMachineExtensionsListResult DeserializeVirtualMachineExtensionsListResult(JsonElement element)
        {
            IReadOnlyList<VirtualMachineExtension> value = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<VirtualMachineExtension> array = new List<VirtualMachineExtension>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        if (item.ValueKind == JsonValueKind.Null)
                        {
                            array.Add(null);
                        }
                        else
                        {
                            array.Add(VirtualMachineExtension.DeserializeVirtualMachineExtension(item));
                        }
                    }
                    value = array;
                    continue;
                }
            }
            return new VirtualMachineExtensionsListResult(value);
        }
    }
}
