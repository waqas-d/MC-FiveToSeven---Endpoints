using MC_FiveToSeven___Endpoints.Services.OddOrEven;
using Microsoft.AspNetCore.Mvc;

namespace MC_FiveToSeven___Endpoints.Controllers;

[ApiController] // Telling dotnet to read this file as an Api Controller
[Route("[controller]")] // Removing the need to type controller to access this file
    public class OddOrEvenController : ControllerBase
    {
         private readonly IOddOrEvenService _OddOrEvenService;

    public OddOrEvenController(IOddOrEvenService OddOrEvenService){
        _OddOrEvenService = OddOrEvenService;
    }

    [HttpGet] // use Get to get/pull data
    [Route("GetOddOrEvenResult/{firstNum}")] // Route name does not have to match Method name, but Routes give a specific Address to each Method
     public string GetOddOrEvenResult(string firstNum)
    {   
        return _OddOrEvenService.GetOddOrEvenResult(firstNum);
    }

    }