using Business_Logic_Layer.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_Logic_Layer.Interfaces
{
    public interface ICategoryBLL
    {
        public Task<List<CategoryModel>> GetCategories();

        public Task<IActionResult> PostCategory(CategoryModel catedory);

        public Task<IActionResult> DeleteCategory(int id);

        public Task<IActionResult> PutCategory(CategoryModel categoryModel);

    }
}
