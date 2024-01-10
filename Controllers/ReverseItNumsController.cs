using MC_FiveToSeven___Endpoints.Services.ReverseItNums;
using Microsoft.AspNetCore.Mvc;

namespace MC_FiveToSeven___Endpoints.Controllers;

[ApiController] // Telling dotnet to read this file as an Api Controller
[Route("[controller]")] // Removing the need to type controller to access this file
    public class ReverseItNumsController : ControllerBase
    {
         private readonly IReverseItNumsService _ReverseItNumsService;

    public ReverseItNumsController(IReverseItNumsService ReverseItNumsService){
        _ReverseItNumsService = ReverseItNumsService;
    }

    [HttpGet] // use Get to get/pull data
    [Route("GetReverseItNumsResult/{userRevNums}")] // Route name does not have to match Method name, but Routes give a specific Address to each Method
     public string GetReverseItNumsResult(string userRevNums)
    {   
        return _ReverseItNumsService.GetReverseItNumsResult(userRevNums);
    }

    }