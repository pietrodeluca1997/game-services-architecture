IDistributedApplicationBuilder builder = DistributedApplication.CreateBuilder(args);

IResourceBuilder<ProjectResource> gameProfileWebAPI = builder.AddProject<Projects.GSA_GameProfile_WebAPI>("game-profile-web-api");

builder.AddProject<Projects.GSA_Game_BFF>("game-bff")
    .WithReference(gameProfileWebAPI);

builder.Build().Run();