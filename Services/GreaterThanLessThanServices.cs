namespace CadeRBackendTwoToFour.Services
{
    public class GreaterThanLessThanServices
    {
        public string GreaterOrLesser(int number1, int number2)
        {
            if(number1 > number2)
            {
                return $"Number one is greater than Number two. And Number two is less than Number one.";
            }
            else if(number1 < number2)
            {
                return $"Number one is less than Number two. And Number two is greater than Number one.";
            }
            else if(number1 == number2)
            {
                return $"Number one is equal to Number two. And Number two is equal to Number one.";
            }
            else
            {
                return "Invalid";
            }
        }
    }
}