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
    public class CategoryDAL : ICategoryDAL
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

        public async Task<bool> PostCategory(Category category)
        {
            dataBaseContext.Add(category);
            var posted = await dataBaseContext.SaveChangesAsync();
            return posted > 0;
        }


        public async Task<bool> DeleteCategory(int id)
        {
            Category category = dataBaseContext.Categories.FirstOrDefault(x => x.Id == id);
            dataBaseContext.Categories.Remove(category);
            var updated = await dataBaseContext.SaveChangesAsync();
            return updated > 0;
        }

        public async Task<bool> PutCategory(Category categoryModel)
        {
            dataBaseContext.Update(categoryModel);
            var deleted = await dataBaseContext.SaveChangesAsync();
            return deleted > 0;
        }

    }
}
