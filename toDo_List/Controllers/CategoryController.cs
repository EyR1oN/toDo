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
    public class CategoryController : ControllerBase
    {
        private Business_Logic_Layer.CategoryBLL _BLL;
        
        public CategoryController()
        {
            _BLL = new Business_Logic_Layer.CategoryBLL();
        }

        [HttpGet]
        public List<CategoryModel> GetCategories()
        {
            return _BLL.GetCategories();
        }

        [HttpPost]
        public void PostCategory(CategoryModel toDo)
        {
            _BLL.PostCategory(toDo);
        }


        [HttpDelete]
        public void DeleteCategory(int id)
        {
            _BLL.DeleteCategory(id);
        }
    }
}
