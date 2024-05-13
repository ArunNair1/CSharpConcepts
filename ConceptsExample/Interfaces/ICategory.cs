using ConceptsExample.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConceptsExample.Interfaces
{
    public interface ICategory
    {
        public List<CategoryModel> GetCategories();
    }
}
