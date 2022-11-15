using Data_Access_Layer.Repository.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Data_Access_Layer.Interfaces
{
    public interface ICategoryDAL
    {

        public Task<List<Category>> GetCategories();

        public Task<bool> PostCategory(Category category);

        public Task<bool> DeleteCategory(int id);

        public Task<bool> PutCategory(Category categoryModel);
    }
}
