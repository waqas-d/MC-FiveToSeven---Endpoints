using MC_FiveToSeven___Endpoints.Services.MadLib;
using Microsoft.AspNetCore.Mvc;

namespace MC_FiveToSeven___Endpoints.Controllers;

[ApiController] // Telling dotnet to read this file as an Api Controller
[Route("[controller]")] // Removing the need to type controller to access this file
    public class MadLibController : ControllerBase
    {
         private readonly IMadLibService _MadLibService;

    public MadLibController(IMadLibService MadLibService){
        _MadLibService = MadLibService;
    }

    [HttpGet] // use Get to get/pull data
    [Route("GetMadLibResult/{fullName}/{verbEndingWithS}/{favoriteSport}/{pronounHeOrShe}/{verb}/{adverb}/{preposition}/{timeWokeUp} {anotherPronoun}/{verbPastTense}")] // Route name does not have to match Method name, but Routes give a specific Address to each Method
    public string GetMadLibResult(string fullName, string verbEndingWithS, string favoriteSport, string pronounHeOrShe, string verb, string adverb, string preposition, string timeWokeUp, string anotherPronoun, string verbPastTense)
    {   
        return _MadLibService.GetMadLibResult(fullName, verbEndingWithS, favoriteSport, pronounHeOrShe, verb, adverb, preposition, timeWokeUp, anotherPronoun, verbPastTense);
    }

    }