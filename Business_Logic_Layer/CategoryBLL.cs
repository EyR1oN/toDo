using Business_Logic_Layer.AutoMapper;
using Business_Logic_Layer.Models;
using Data_Access_Layer.Repository.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_Logic_Layer
{
    public class CategoryBLL
    {

        private Data_Access_Layer.CategoryDAL _DAL;

        public CategoryBLL()
        {
            _DAL = new Data_Access_Layer.CategoryDAL();
        }

        public List<CategoryModel> GetCategories()
        {
            var categoriesEntity = _DAL.GetCategories();
            List<CategoryModel> categoriesModel = MyAutoMapper<Category, CategoryModel>.MapList(categoriesEntity);

            return categoriesModel;
        }

        public void PostCategory(CategoryModel catedory)
        {
            Category categoryEntity = MyAutoMapper<CategoryModel, Category>.Map(catedory);
            _DAL.PostCategory(categoryEntity);
        }


        public void DeleteCategory(int id)
        {
            _DAL.DeleteCategory(id);
        }

        public void PutCategory(CategoryModel categoryModel)
        {
            Category categoryEntity = MyAutoMapper<CategoryModel, Category>.Map(categoryModel);
            _DAL.PostCategory(categoryEntity);
        }
    }
}
