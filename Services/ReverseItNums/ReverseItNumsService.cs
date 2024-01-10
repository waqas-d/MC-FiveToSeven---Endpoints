namespace MC_FiveToSeven___Endpoints.Services.ReverseItNums;

public class ReverseItNumsService : IReverseItNumsService
{
    public string GetReverseItNumsResult(string userRevNums)

    {
        bool correctNum1 = int.TryParse(userRevNums, out int userFirstNum);

        if (correctNum1 == true)
        {

            string reverseResult = "";
            for (int i = userRevNums.Length - 1; i >= 0; i--)
            {
                reverseResult += userRevNums[i];
            }

            return $"You enter {userFirstNum}, reversed is {reverseResult}.";
        }
        else
        {
            return "Please enter a whole number.";
        }

    }

}
