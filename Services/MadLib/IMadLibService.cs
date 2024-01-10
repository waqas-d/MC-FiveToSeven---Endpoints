namespace MC_FiveToSeven___Endpoints.Services.MadLib;

    public interface IMadLibService
    {
        string GetMadLibResult(string fullName, string verbEndingWithS, string favoriteSport, string pronounHeOrShe, string verb, string adverb, string preposition, string timeWokeUp, string anotherPronoun, string verbPastTense);
    }
