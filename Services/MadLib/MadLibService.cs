namespace MC_FiveToSeven___Endpoints.Services.MadLib;

    public class MadLibService : IMadLibService
    {

            public string GetMadLibResult(string fullName, string verbEndingWithS, string favoriteSport, string pronounHeOrShe, string verb, string adverb, string preposition, string timeWokeUp, string anotherPronoun, string verbPastTense)
            {
                return $"{fullName} {verbEndingWithS} {favoriteSport}. {pronounHeOrShe} {verb} {adverb} {preposition} {timeWokeUp} {anotherPronoun} {verbPastTense}.";
            }
    
    }
