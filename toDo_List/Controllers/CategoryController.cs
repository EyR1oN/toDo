using Business_Logic_Layer.Interfaces;
using Business_Logic_Layer.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace toDo_List.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CategoryController : ControllerBase
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
           if(await _BLL.PostCategory(toDo))
           {
                return Ok();
           }
           return BadRequest();
        }

        [HttpPut]
        public async Task<IActionResult> PutCategory(CategoryModel toDo)
        {
            if (await _BLL.PutCategory(toDo))
            {
                return Ok();
            }
            return BadRequest();
        }


        [HttpDelete]
        public async Task<IActionResult> DeleteCategory(int id)
        {
            if (await _BLL.DeleteCategory(id))
            {
                return Ok();
            }
            return BadRequest();
        }
    }
}
