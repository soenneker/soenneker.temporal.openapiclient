[![](https://img.shields.io/nuget/v/soenneker.temporal.openapiclient.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.temporal.openapiclient/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.temporal.openapiclient/publish-package.yml?style=for-the-badge)](https://github.com/soenneker/soenneker.temporal.openapiclient/actions/workflows/publish-package.yml)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.temporal.openapiclient/codeql.yml?label=CodeQL&style=for-the-badge)](https://github.com/soenneker/soenneker.temporal.openapiclient/actions/workflows/codeql.yml)
[![](https://img.shields.io/nuget/dt/soenneker.temporal.openapiclient.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.temporal.openapiclient/)

# ![](https://user-images.githubusercontent.com/4441470/224455560-91ed3ee7-f510-4041-a8d2-3fc093025112.png) Soenneker.Temporal.OpenApiClient
A Kiota-generated client for Temporal's HTTP data-plane API.

## Installation

```bash
dotnet add package Soenneker.Temporal.OpenApiClient
```

## Usage

```csharp
using System.Net.Http.Headers;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;
using Soenneker.Temporal.OpenApiClient;
using Soenneker.Temporal.OpenApiClient.Models;

var httpClient = new HttpClient
{
    BaseAddress = new Uri("https://your-namespace.your-account.tmprl.cloud/")
};

httpClient.DefaultRequestHeaders.Authorization =
    new AuthenticationHeaderValue("Bearer", temporalApiKey);

var authentication = new AnonymousAuthenticationProvider();
var adapter = new HttpClientRequestAdapter(authentication, httpClient: httpClient);
var temporal = new TemporalOpenApiClient(adapter);

GetSystemInfoResponse? systemInfo =
    await temporal.Api.V1.SystemInfo.GetAsync(cancellationToken: cancellationToken);
```

Reuse the `TemporalOpenApiClient`, request adapter, and `HttpClient` rather than creating them for every request.

This package exposes Temporal's generated HTTP endpoints. Use a Temporal SDK when you need to run workers or author workflows, and use a Cloud Ops client for account-level resources such as users and namespaces.

Generated request builders follow the OpenAPI path hierarchy. For example, `/api/v1/system-info` is available through `temporal.Api.V1.SystemInfo`.
