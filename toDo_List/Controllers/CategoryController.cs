using Business_Logic_Layer;
using Business_Logic_Layer.Interfaces;
using Business_Logic_Layer.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ApplicationModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace toDo_List.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CategoryController 
    {
        private ICategoryBLL _BLL;
        
        public CategoryController(ICategoryBLL BLL)
        {
            _BLL = BLL;
        }

        [HttpGet]
        public async Task<List<CategoryModel>> GetCategories()
        {
            return await _BLL.GetCategories();
        }

        [HttpPost]
        public async Task<IActionResult> PostCategory(CategoryModel toDo)
        {
           return await _BLL.PostCategory(toDo);
        }

        [HttpPut]
        public async Task<IActionResult> PutCategory(CategoryModel toDo)
        {
            return await _BLL.PutCategory(toDo);
        }


        [HttpDelete]
        public async Task<IActionResult> DeleteCategory(int id)
        {
            return await _BLL.DeleteCategory(id);
        }
    }
}
