/**
 * CompletionMessageAssistant automatically generated by SDKgen please do not edit this file manually
 * @see https://sdkgen.app
 */

using System.Text.Json.Serialization;

namespace SdkFabric.Openai;

public class CompletionMessageAssistant : CompletionMessage
{
    [JsonPropertyName("audio")]
    public string? Audio { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("refusal")]
    public string? Refusal { get; set; }

    [JsonPropertyName("tool_calls")]
    public System.Collections.Generic.List<string>? ToolCalls { get; set; }

}

