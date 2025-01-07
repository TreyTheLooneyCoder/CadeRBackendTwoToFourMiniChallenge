using Microsoft.AspNetCore.Mvc;
using CadeRBackendTwoToFour.Services;

namespace CadeRBackendTwoToFour.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AskingQuestionsController : ControllerBase
    {
        private readonly AskingQuestionsServices _askingQuestionsServices;
        public AskingQuestionsController(AskingQuestionsServices askingQuestionsServices)
        {
            _askingQuestionsServices = askingQuestionsServices;
        }

        [HttpGet]
        [Route("Asking/{name}/{time}")]
        public string AskQuestions(string name, string time)
        {
            return _askingQuestionsServices.AskQuestions(name, time);
        }
    }
}