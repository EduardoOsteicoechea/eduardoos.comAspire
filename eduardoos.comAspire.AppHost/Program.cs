var builder = DistributedApplication.CreateBuilder(args);

var apiService = builder.AddProject<Projects.eduardoos_comAspire_ApiService>("apiservice");

builder.AddProject<Projects.eduardoos_comAspire_Web>("webfrontend")
    .WithExternalHttpEndpoints()
    .WithReference(apiService);

builder.Build().Run();
