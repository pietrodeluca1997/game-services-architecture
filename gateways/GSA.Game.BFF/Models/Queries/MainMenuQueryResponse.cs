using GSA.ApplicationDefaults.Helpers;
using GSA.Core.Queries;
using GSA.Core.Queries.Shared;
using GSA.ServiceDefaults.Models;

namespace GSA.Game.BFF.Models.Queries;

public record MainMenuQueryResponse : HateoasResponse, IQueryResponse
{
    public Uri OfficialDiscordLink { get; set; }
    public string CopyrightMessage { get; set; }
    public string BuildVersion { get; set; }
    public string EnvironmentName { get; set; }
    public CharacterListQueryResponse CharactersList { get; set; }

    public MainMenuQueryResponse()
    {
        // Mock
        OfficialDiscordLink = new Uri("https://discord.com/");
        CopyrightMessage = $"Game Project®. All rights reserved. Designed and Developed by De Luca ©{DateTime.Now.Year}.";
        BuildVersion = "0.0.1";
        EnvironmentName = EnvironmentHelper.GetEnvironmentName();
    }
}
