using ConceptsExample.Interfaces;
using ConceptsExample.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConceptsExample.Controller
{
    //if I need to change this implementation I only need to make changes in this class
    //or else if I need to implement this in a new class then I need to change in program.cs
    //by editing the line bulider.services.AddScoped<ICategory, ??>.
    //This is dependency injection.
    public class CategoryController : ICategory
    {
        public List<CategoryModel> GetCategories()
        {
            var categoryList = new List<CategoryModel>();
            categoryList.Add(new CategoryModel { Id=1,Name="test" });
            return categoryList;
        }
    }
}
