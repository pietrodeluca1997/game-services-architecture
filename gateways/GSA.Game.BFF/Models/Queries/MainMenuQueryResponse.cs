using GSA.ApplicationDefaults.Helpers;
using HttpMethod = Microsoft.AspNetCore.Server.Kestrel.Core.Internal.Http.HttpMethod;
using GSA.ServiceDefaults.Models;

namespace GSA.Game.BFF.Models.Queries;

public record MainMenuQueryResponse
{
    public Uri OfficialDiscordLink { get; set; }
    public string CopyrightMessage { get; set; }
    public string BuildVersion { get; set; }
    public string EnvironmentName { get; set; }

    public MainMenuQueryResponse()
    {
        // Mock
        OfficialDiscordLink = new Uri("");
        CopyrightMessage = $"Game Project®. All rights reserved. Designed and Developed by De Luca ©{DateTime.Now.Year}.";
        BuildVersion = "0.0.1";
        EnvironmentName = EnvironmentHelper.GetEnvironmentName();
    }
}
