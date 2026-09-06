
# openai-csharp

This [SDK](https://github.com/sdk-fabric/openai-csharp) is managed by the [SDK Fabric](https://sdk-fabric.org/) project, a global infrastructure to
automatically generate SDKs for every API.

You can find more information about this SDK at [TypeHub](https://typehub.cloud/):
https://app.typehub.cloud/d/sdkfabric/openai

## Usage

```csharp
using SdkFabric.Openai.Client;

Client client = Client.Build("[access_token]")

// Creates a model response for the given chat conversation.
CompletionResponse response = client.Completions().Create(new CompletionRequest());

// Delete a stored chat completion.
CompletionDeleted response = client.Completions().Delete("completion_id");

// List stored Chat Completions.
CompletionCollection response = client.Completions().Getall("after", 1, "model", "order");

// Creates a model response.
ResponseResponse response = client.Responses().Create(new ResponseRequest());
```
