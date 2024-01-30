using GSA.Game.BFF.Models.Queries;
using GSA.ServiceDefaults.Controllers;
using Microsoft.AspNetCore.Mvc;

namespace GSA.Game.BFF.Controllers;

[Route("main-menu")]
public class MainMenuController : RestAPIController
{
    [HttpGet]
    public async Task<IActionResult> GetRequiredData()
    {
        await Task.CompletedTask;

        return Ok(new MainMenuQueryResponse());
    }
}
