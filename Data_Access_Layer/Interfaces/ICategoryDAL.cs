using Data_Access_Layer.Repository.Entities;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Access_Layer.Interfaces
{
    public interface ICategoryDAL
    {

        public Task<List<Category>> GetCategories();

        public Task<IActionResult> PostCategory(Category category);

        public Task<IActionResult> DeleteCategory(int id);

        public Task<IActionResult> PutCategory(Category categoryModel);
    }
}
