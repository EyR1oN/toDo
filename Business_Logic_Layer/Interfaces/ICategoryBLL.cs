using Business_Logic_Layer.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Business_Logic_Layer.Interfaces
{
    public interface ICategoryBLL
    {
        public Task<List<CategoryModel>> GetCategories();

        public Task<bool> PostCategory(CategoryModel catedory);

        public Task<bool> DeleteCategory(int id);

        public Task<bool> PutCategory(CategoryModel categoryModel);

    }
}
