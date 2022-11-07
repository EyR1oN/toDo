using Data_Access_Layer.Repository;
using Data_Access_Layer.Repository.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Access_Layer
{
    public class CategoryDAL
    {

        public List<Category> GetCategories()
        {
            var db = new ToDoListDbContext();
            return db.Categories.ToList();
        }

        public void PostCategory(Category category)
        {
            var db = new ToDoListDbContext();
            db.Add(category);
            db.SaveChanges();
        }


        public void DeleteCategory(int id)
        {
            var db = new ToDoListDbContext();
            Category category = db.Categories.FirstOrDefault(x => x.Id == id);
            db.Categories.Remove(category);
            db.SaveChanges();
        }

        public void PutCategory(Category categoryModel)
        {
            var db = new ToDoListDbContext();
            db.Update(categoryModel);
            db.SaveChanges();
        }

    }
}
