using ConceptsExample;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace CSharpConcepts_Sol.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SampleController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<SampleController> _logger;

        public SampleController(ILogger<SampleController> logger)
        {
            _logger = logger;
        }

        //[HttpGet(Name = "GetWeatherForecast")]
        //public IEnumerable<WeatherForecast> Get()
        //{
        //    return Enumerable.Range(1, 5).Select(index => new WeatherForecast
        //    {
        //        Date = DateTime.Now.AddDays(index),
        //        TemperatureC = Random.Shared.Next(-20, 55),
        //        Summary = Summaries[Random.Shared.Next(Summaries.Length)]
        //    })
        //    .ToArray();
        //}

        [HttpGet(Name = "GenericsExample")]
        public IActionResult GenericsExample()
        {
            
            CallingClass callingClass = new CallingClass();
            var val1 = callingClass.callMyGenericClass<int>(1);

            var val2 = callingClass.callMyGenericClass<string>("test");

            MyModel myModel = new MyModel();
            myModel.rollNo = 1;
            myModel.FirstName = "Test";
            myModel.LastName = "Test2";

            var val3 = callingClass.callMyGenericClass<MyModel>(myModel);
            object a = new{
                val1 = 1,
                val2 = "test",
                val3 = myModel
                };
            return Ok(a);
        }

    }
}