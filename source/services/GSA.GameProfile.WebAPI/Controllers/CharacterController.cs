using GSA.Core.Queries.Shared;
using GSA.ServiceDefaults.Controllers;
using Microsoft.AspNetCore.Mvc;

namespace GSA.GameProfile.WebAPI.Controllers;

[Route("/characters")]
public class CharacterController : RestAPIController
{
    [HttpGet]
    public async Task<IActionResult> ListCharacters()
    {
        await Task.CompletedTask;

        return Ok(new CharacterListQueryResponse());
    }
}
