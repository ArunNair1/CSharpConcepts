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

        [HttpGet]
        public IActionResult AsyncAwaitExample()
        {
            ClassForAsyncAwait classForAsyncAwait = new ClassForAsyncAwait();
            var result = new { res = classForAsyncAwait.useAllMethods() };


            return Ok(result);
        }

        [HttpGet]
        public IActionResult ThreadClassExample()
        {
            ClassForAsyncAwait classForAsyncAwait = new ClassForAsyncAwait();
            var out1 = "";
            Task t1 = Task.Run(() => out1 =  classForAsyncAwait.PrintNumbers() );
            Task t2 = Task.Run(() => out1 += classForAsyncAwait.PrintNumbers() );

            Task.WhenAll(t1, t2).Wait(); //makes sure both t1 and t2 are complete before moving forward
            var result = new { t1Status = t1.Status, t2Status = t2.Status };


            return Ok(result);
        }
    }
}
