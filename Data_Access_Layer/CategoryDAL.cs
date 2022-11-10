using Data_Access_Layer.Repository;
using Data_Access_Layer.Repository.Entities;
using System;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Data_Access_Layer.Interfaces;

namespace Data_Access_Layer
{
    public class CategoryDAL : ControllerBase, ICategoryDAL
    {
        private readonly ToDoListDbContext dataBaseContext;
        public CategoryDAL(ToDoListDbContext _dataBaseContext)
        {
            dataBaseContext = _dataBaseContext;
        }

        public async Task<List<Category>> GetCategories()
        {
            return await dataBaseContext.Categories.ToListAsync();
        }

        public async Task<IActionResult> PostCategory(Category category)
        {
            dataBaseContext.Add(category);
            await dataBaseContext.SaveChangesAsync();
            return Ok();
        }


        public async Task<IActionResult> DeleteCategory(int id)
        {
            Category category = dataBaseContext.Categories.FirstOrDefault(x => x.Id == id);
            dataBaseContext.Categories.Remove(category);
            await dataBaseContext.SaveChangesAsync();
            return NoContent();
        }

        public async Task<IActionResult> PutCategory(Category categoryModel)
        {
            dataBaseContext.Update(categoryModel);
            await dataBaseContext.SaveChangesAsync();
            return Ok();
        }

    }
}
