using ConceptsExample;
using ConceptsExample.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CSharpConcepts_Sol.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class DelegateExampleController : ControllerBase
    {
        private ICategory _category;
        public DelegateExampleController(ICategory category)
        {
            _category= category;
        }

        [HttpGet]
        public IActionResult GetDelegateExampleOutput()
        {
            return new JsonResult(ClassForDelegates.callMyDelegates());
        }

        [HttpGet]
        public IActionResult GetCatgories()
        {
            var val = _category.GetCategories();

            return new JsonResult(val);
        }
    }
}
