using GSA.Game.BFF.Models.Queries;
using GSA.ServiceCommunicationChannel.Providers;
using GSA.ServiceDefaults.Controllers;
using Microsoft.AspNetCore.Mvc;

namespace GSA.Game.BFF.Controllers;

[Route("main-menu")]
public class MainMenuController(GameProfileServiceCommunicationProvider gameProfileProvider) : RestAPIController
{
    [HttpGet]
    public async Task<IActionResult> GetMainMenuData()
    {
        MainMenuQueryResponse mainMenuData = new()
        {
            CharactersList = await gameProfileProvider.GetCharactersList()
        };

        return Ok(mainMenuData);
    }
}
