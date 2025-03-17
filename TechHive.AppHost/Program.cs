var builder = DistributedApplication.CreateBuilder(args);

var apiService = builder.AddProject<Projects.TechHive_ApiService>("apiservice");

builder.AddProject<Projects.TechHive_Web>("webfrontend")
    .WithExternalHttpEndpoints()
    .WithReference(apiService)
    .WaitFor(apiService);

builder.Build().Run();
