namespace CadeRBackendTwoToFour.Services
{
    public class AddingNumbersServices
    {
        public string AddTwoNumbers(int num1, int num2)
        {
            int total = num1 + num2;

            return $"The sum of {num1} + {num2} is equal to {total}";
        }
    }
}