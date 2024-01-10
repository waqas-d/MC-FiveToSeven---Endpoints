namespace MC_FiveToSeven___Endpoints.Services.OddOrEven;

    public class OddOrEvenService : IOddOrEvenService
    {
        public string GetOddOrEvenResult(string firstNum)
        {

            bool correctNum1 =  int.TryParse(firstNum, out int userFirstNum);

            if(correctNum1 == true){

                if(userFirstNum % 2 == 0){
                    return $"{userFirstNum} is an even number.";
                }else{
                    return $"{userFirstNum} is an odd number.";
                }
            }else{
                return "Please enter a whole number.";
            }


        }
    }
