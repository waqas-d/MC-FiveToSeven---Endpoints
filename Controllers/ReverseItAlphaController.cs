using MC_FiveToSeven___Endpoints.Services.ReverseItAlpha;
using Microsoft.AspNetCore.Mvc;

namespace MC_FiveToSeven___Endpoints.Controllers;

[ApiController] // Telling dotnet to read this file as an Api Controller
[Route("[controller]")] // Removing the need to type controller to access this file
    public class ReverseItAlphaController : ControllerBase
    {
         private readonly IReverseItAlphaService _ReverseItAlphaService;

    public ReverseItAlphaController(IReverseItAlphaService ReverseItAlphaService){
        _ReverseItAlphaService = ReverseItAlphaService;
    }

    [HttpGet] // use Get to get/pull data
    [Route("GetReverseItAlphaResult/{userRevNumsLetts}")] // Route name does not have to match Method name, but Routes give a specific Address to each Method
     public string GetReverseItAlphaResult(string userRevNumsLetts)
    {   
        return _ReverseItAlphaService.GetReverseItAlphaResult(userRevNumsLetts);
    }

    }