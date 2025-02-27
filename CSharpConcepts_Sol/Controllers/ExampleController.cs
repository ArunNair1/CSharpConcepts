using ConceptsExample;
using ConceptsExample.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CSharpConcepts_Sol.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ExampleController : ControllerBase
    {
        private ICategory _category;
        public ExampleController(ICategory category)
        {
            _category= category;
        }

        [HttpGet]
        public IActionResult GetGenericExmapleOutput()
        {
            CallingClass callingClass = new CallingClass();
            // var val = callingClass.callMyGenericClass<int>();
            var val = callingClass.callMyGenericClass<string>("test");
            //var val = callingClass.callMyGenericClass<MyModel>(); //this will fail

            return new JsonResult(val);
        }

        [HttpGet]
        public IActionResult GetCatgories()
        {
            var val = _category.GetCategories();

            return new JsonResult(val);
        }
    }
}
