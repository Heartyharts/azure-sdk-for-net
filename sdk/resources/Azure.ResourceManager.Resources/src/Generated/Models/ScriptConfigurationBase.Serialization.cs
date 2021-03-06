// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Resources.Models
{
    public partial class ScriptConfigurationBase : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (PrimaryScriptUri != null)
            {
                writer.WritePropertyName("primaryScriptUri");
                writer.WriteStringValue(PrimaryScriptUri);
            }
            if (SupportingScriptUris != null)
            {
                writer.WritePropertyName("supportingScriptUris");
                writer.WriteStartArray();
                foreach (var item in SupportingScriptUris)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (ScriptContent != null)
            {
                writer.WritePropertyName("scriptContent");
                writer.WriteStringValue(ScriptContent);
            }
            if (Arguments != null)
            {
                writer.WritePropertyName("arguments");
                writer.WriteStringValue(Arguments);
            }
            if (EnvironmentVariables != null)
            {
                writer.WritePropertyName("environmentVariables");
                writer.WriteStartArray();
                foreach (var item in EnvironmentVariables)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (ForceUpdateTag != null)
            {
                writer.WritePropertyName("forceUpdateTag");
                writer.WriteStringValue(ForceUpdateTag);
            }
            writer.WritePropertyName("retentionInterval");
            writer.WriteStringValue(RetentionInterval, "P");
            if (Timeout != null)
            {
                writer.WritePropertyName("timeout");
                writer.WriteStringValue(Timeout.Value, "P");
            }
            writer.WriteEndObject();
        }

        internal static ScriptConfigurationBase DeserializeScriptConfigurationBase(JsonElement element)
        {
            string primaryScriptUri = default;
            IList<string> supportingScriptUris = default;
            string scriptContent = default;
            string arguments = default;
            IList<EnvironmentVariable> environmentVariables = default;
            string forceUpdateTag = default;
            TimeSpan retentionInterval = default;
            TimeSpan? timeout = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("primaryScriptUri"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    primaryScriptUri = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("supportingScriptUris"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        if (item.ValueKind == JsonValueKind.Null)
                        {
                            array.Add(null);
                        }
                        else
                        {
                            array.Add(item.GetString());
                        }
                    }
                    supportingScriptUris = array;
                    continue;
                }
                if (property.NameEquals("scriptContent"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    scriptContent = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("arguments"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    arguments = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("environmentVariables"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<EnvironmentVariable> array = new List<EnvironmentVariable>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        if (item.ValueKind == JsonValueKind.Null)
                        {
                            array.Add(null);
                        }
                        else
                        {
                            array.Add(EnvironmentVariable.DeserializeEnvironmentVariable(item));
                        }
                    }
                    environmentVariables = array;
                    continue;
                }
                if (property.NameEquals("forceUpdateTag"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    forceUpdateTag = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("retentionInterval"))
                {
                    retentionInterval = property.Value.GetTimeSpan("P");
                    continue;
                }
                if (property.NameEquals("timeout"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    timeout = property.Value.GetTimeSpan("P");
                    continue;
                }
            }
            return new ScriptConfigurationBase(primaryScriptUri, supportingScriptUris, scriptContent, arguments, environmentVariables, forceUpdateTag, retentionInterval, timeout);
        }
    }
}
