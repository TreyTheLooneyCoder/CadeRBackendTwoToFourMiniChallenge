using Microsoft.AspNetCore.Mvc;
using CadeRBackendTwoToFour.Services;


namespace CadeRBackendTwoToFour.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AddingNumbersController : ControllerBase
    {
        private readonly AddingNumbersServices _addingNumbersServices;
        public AddingNumbersController(AddingNumbersServices addingNumbersServices)
        {
            _addingNumbersServices = addingNumbersServices;
        }

        [HttpGet]
        [Route("Adding/{num1}/{num2}")]
        public string AddTwoNumbers(int num1, int num2)
        {
            return _addingNumbersServices.AddTwoNumbers(num1, num2);
        }
    }
}