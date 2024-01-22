IDistributedApplicationBuilder builder = DistributedApplication.CreateBuilder(args);

builder.AddProject<Projects.GSA_POC_WebAPI>("poc-web-api");
        
builder.Build().Run();