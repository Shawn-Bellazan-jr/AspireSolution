var builder = DistributedApplication.CreateBuilder(args);

var cache = builder.AddRedis("cache");

var apiService = builder.AddProject<Projects.Aspire_ApiService>("apiservice");

builder.AddProject<Projects.Aspire_Web>("webfrontend")
    .WithExternalHttpEndpoints()
    .WithReference(cache)
    .WaitFor(cache)
    .WithReference(apiService)
    .WaitFor(apiService);

builder.AddProject<Projects.Aspire_GrpcService>("aspire-grpcservice");

builder.Build().Run();