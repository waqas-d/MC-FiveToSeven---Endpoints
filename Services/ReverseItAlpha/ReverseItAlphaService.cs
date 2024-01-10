namespace MC_FiveToSeven___Endpoints.Services.ReverseItAlpha;

    public class ReverseItAlphaService : IReverseItAlphaService
    {
           public string GetReverseItAlphaResult(string userRevNumsLetts)

        {  
            string reverseResult = ""; 
            for (int i = userRevNumsLetts.Length -1; i >= 0; i--)
            {
            reverseResult += userRevNumsLetts[i];
            }

            return $"You entered {userRevNumsLetts}, reversed it {reverseResult}.";


        }
    
}