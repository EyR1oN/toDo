using Data_Access_Layer.Repository;
using Data_Access_Layer.Repository.Entities;
using System;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Data_Access_Layer
{
    public class CategoryDAL : ControllerBase
    {

        public async Task<List<Category>> GetCategories()
        {
            var db = new ToDoListDbContext();
            return await db.Categories.ToListAsync();
        }

        public async Task<IActionResult> PostCategory(Category category)
        {
            var db = new ToDoListDbContext();
            db.Add(category);
            await db.SaveChangesAsync();
            return Ok();
        }


        public async Task<IActionResult> DeleteCategory(int id)
        {
            var db = new ToDoListDbContext();
            Category category = db.Categories.FirstOrDefault(x => x.Id == id);
            db.Categories.Remove(category);
            await db.SaveChangesAsync();
            return NoContent();
        }

        public async Task<IActionResult> PutCategory(Category categoryModel)
        {
            var db = new ToDoListDbContext();
            db.Update(categoryModel);
            await db.SaveChangesAsync();
            return Ok();
        }

    }
}
