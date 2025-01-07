
using Microsoft.AspNetCore.Mvc;
using CadeRBackendTwoToFour.Services;

namespace CadeRBackendTwoToFour.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class GreaterThanLessThanController : ControllerBase
    {
        private readonly GreaterThanLessThanServices _greaterThanLessThanServices;
        public GreaterThanLessThanController(GreaterThanLessThanServices greaterThanLessThanServices)
        {
            _greaterThanLessThanServices = greaterThanLessThanServices;
        }

        [HttpGet]
        [Route("Comparing/{number1}/{number2}")]
        public string GreaterOrLesser(int number1, int number2)
        {
            return _greaterThanLessThanServices.GreaterOrLesser(number1, number2);
        }
    }
}